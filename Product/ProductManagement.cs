using System;
using System.Linq;
using System.Windows.Forms;
using Humanizer;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class ProductManagement : MetroForm
    {
        private int _lastSelectedRow;
        private static ProductManagement _productManagement;
        public ProductManagement()
        {
            InitializeComponent();
            UpdateProductsGrid();
        }

        public static ProductManagement GetInstance()
        {
            if (_productManagement is null) _productManagement = new ProductManagement();
            return _productManagement.IsDisposed ? _productManagement = new ProductManagement() : _productManagement;
        }
        private void UpdateProductsGrid(string query = null)
        {
            var database = new AromasDatabaseEntities();
            var products = string.IsNullOrWhiteSpace(query)
                ? database.Product.Where(p => p.Category == "P").OrderBy(p => p.Specification)
                : database.Product
                    .Where(p => p.Category == "P" && (p.Specification.Contains(query) || p.Barcode.Contains(query)))
                    .OrderBy(p => p.Specification);

            var datasource = products.Select(product =>
                new
                {
                    product.ProductId,
                    product.Barcode,
                    product.Specification,
                    product.Price,
                    product.InventoryAmount
                });

            productsGrid.DataSource = datasource.ToList();

            if (productsGrid.RowCount is 0 || productsGrid.RowCount <= _lastSelectedRow) return;
            productsGrid.CurrentCell = productsGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addProduct = new AddUpdateProduct();
            if (addProduct.ShowDialog() == DialogResult.OK)
                UpdateProductsGrid();
        }

        private void ProductsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = productsGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = productsGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            var productId = int.Parse(productsGrid.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            if (isEditing)
                EditProduct(productId);
            if (isDeleting)
                DeleteProduct(productId);
        }

        private void DeleteProduct(int productId)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var product = database.Product.Find(productId);
                var confirmationResult = MessageBox.Show(
                    $"Você está prestes a excluir o produto \"{product.Specification}\". Tem certeza disto?",
                    @"Excluindo produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmationResult != DialogResult.Yes) return;
                database.Product.Remove(product);
                database.SaveChanges();
            }

            UpdateProductsGrid();
        }

        private void EditProduct(int productId)
        {
            var editProduct = new AddUpdateProduct(productId);
            if (editProduct.ShowDialog() == DialogResult.OK)
                UpdateProductsGrid();
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            UpdateProductsGrid(searchInput.Text);
            searchInput.Clear();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            productsGrid.AutoGenerateColumns = false;
        }

        private void ProductsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (productsGrid.Columns[e.ColumnIndex].Name == "Specification")
                e.Value = e.Value.ToString().Transform(To.LowerCase, To.TitleCase);
        }

        private void ImportXmlButton_Click(object sender, EventArgs e)
        {
            var importXml = new ImportXml();
            if (importXml.ShowDialog() == DialogResult.OK)
                UpdateProductsGrid();
        }

        private void ProductManagement_Activated(object sender, EventArgs e)
        {
            UpdateProductsGrid();
        }
    }
}