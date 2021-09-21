using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AromasEstoque.Controllers;
using MetroFramework.Forms;

namespace AromasEstoque
{ 
    public partial class ImportXml : MetroForm
    {
        private List<Product> _productList = new List<Product>();
        private readonly XmlImportController _controller = new XmlImportController();
        public ImportXml()
        {
            InitializeComponent();
        }
        private void LoadFileButton_Click(object sender, System.EventArgs e)
        {
            if (openXmlFile.ShowDialog() != DialogResult.OK) return;
            _controller.LoadXmlFromFile(openXmlFile.FileName);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _productList = _controller.GetProductsFromXml();
            productsGrid.DataSource = _productList.Select(p=>new
            {
                p.Barcode,
                p.Specification,
                p.InventoryAmount
            }).ToList();
        }

        private void ImportAllButton_Click(object sender, System.EventArgs e)
        {
           _controller.ImportAllProducts();
            Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
