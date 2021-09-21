using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddUpdateProduct : MetroForm
    {
        private readonly int _productId = -1;

        public AddUpdateProduct()
        {
            InitializeComponent();
        }

        public AddUpdateProduct(int productId)
        {
            _productId = productId;
            InitializeComponent();
            okButton.Text = @"Salvar";
            okButton.Enabled = true;
            LoadProductData();
        }
        public AddUpdateProduct(Product product)
        {
            InitializeComponent();
            LoadProductData(product);
        }


        private void AddProduct()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Product.Add(new Product
                {
                    Barcode = barcodeInput.Text,
                    Category = "P",
                    InventoryAmount = (int)inventorySelector.Value,
                    Price = decimal.Parse(priceInput.Text),
                    Specification = descriptionInput.Text
                });

                database.SaveChanges();
            }
        }

        private void LoadProductData()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var product = database.Product.Find(_productId);
                if (product is null) return;
                descriptionInput.Text = product.Specification;
                priceInput.Text = product.Price.ToString();
                inventorySelector.Value = product.InventoryAmount < 0 ? 0 : product.InventoryAmount;
                barcodeInput.Text = product.Barcode;

                Text = $@"Editando {product.Specification}";
            }
        }
        private void LoadProductData(Product product)
        {
            descriptionInput.Text = product.Specification;
            inventorySelector.Value = product.InventoryAmount < 0 ? 0 : product.InventoryAmount;
            barcodeInput.Text = product.Barcode;
        }
        private void EditProduct()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var product = database.Product.Find(_productId);
                product.Barcode = barcodeInput.Text;
                product.Category = "P";
                product.InventoryAmount = (int)inventorySelector.Value;
                product.Price = decimal.Parse(priceInput.Text);
                product.Specification = descriptionInput.Text;

                database.SaveChanges();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_productId == -1) AddProduct();
            else EditProduct();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PriceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PriceInput_KeyDown(object sender, KeyEventArgs e)
        {
            priceInput.Monify(e);
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            var containsDescription = descriptionInput.Text.Length > 0;
            var containsPrice = decimal.Parse(priceInput.Text) > 0;

            okButton.Enabled = containsPrice && containsDescription;
            AcceptButton = okButton.Enabled ? okButton : null;
        }

        private void BarcodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            descriptionInput.Focus();
        }
    }
}