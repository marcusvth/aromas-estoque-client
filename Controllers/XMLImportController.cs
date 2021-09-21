using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace AromasEstoque.Controllers
{
    class XmlImportController
    {
        private XDocument _xmlDocument;
        private readonly XNamespace _xmlNamespace = "http://www.portalfiscal.inf.br/nfe";
        public string ParseEan13(string ean13)
        {
            if (ean13.Any(char.IsLetter)) return null;
            if (ean13.Length is 13) return ean13;
            if (ean13.Length > 13) return ean13.Substring(ean13.Length - 13);
            var restOfBarcode = new string('0', 13 - ean13.Length);
            return string.Concat(restOfBarcode, ean13);
        }

        private string GetXElementProperty(XElement element, string propertyName) => element.Element(_xmlNamespace + propertyName)?.Value;

        public List<Product> GetProductsFromXml()
        {
                var productList = from element in _xmlDocument.Descendants(_xmlNamespace + "prod")
                select new Product
                {
                    Barcode =  ParseEan13(GetXElementProperty(element, "cEAN")),
                    Specification = GetXElementProperty(element, "xProd"),
                    InventoryAmount = (int) decimal.Parse(GetXElementProperty(element, "qTrib"), CultureInfo.InvariantCulture),
                    Price = 0m
                };

                return productList.ToList();
        }

        private void AddProductToDatabase(Product product)
        {
            new AddUpdateProduct(product).ShowDialog();
        }
        private void ImportFromXml(Product product)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var dbProduct = database.Product.FirstOrDefault(p => p.Barcode.Equals(product.Barcode));

                if (dbProduct is null)
                    AddProductToDatabase(product);
                else
                {
                    dbProduct.InventoryAmount += product.InventoryAmount;
                    database.SaveChanges();
                }
            }
        }
        public void ImportAllProducts()
        {
            var productList = GetProductsFromXml();
            foreach (var product in productList)
                ImportFromXml(product);
        }
        public void LoadXmlFromFile(string filePath)
        {
            _xmlDocument = XDocument.Load(filePath);
        }
    }
}
