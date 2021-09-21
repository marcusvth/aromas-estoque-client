using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AromasEstoque
{
    internal class PointOfSaleController : ISubject
    {
        private readonly List<Product> _cartList = new List<Product>();
        private readonly List<IObserver> _observers = new List<IObserver>();

        private List<Product> _productList;

        private readonly IPointOfSale _view;

        public PointOfSaleController(IPointOfSale view)
        {
            _view = view;
            UpdateProductList();
            Attach(Sales.Instance);
            Attach(TransactionsDashboard.Instance.Controller);
            Attach(PendingPayments.Instance.Controller);
            Attach(ProductManagement.Instance);
            _view.EmployeeList = GetEmployeeList();
        }

        public void UpdateProductList()
        {
            using (var database = new AromasDatabaseEntities())
            {
                _productList = database.Product.ToList();
            }
        }

        private List<Employee> GetEmployeeList()
        {
            var database = new AromasDatabaseEntities();
            return database.Employee.ToList();
        }
        public void SetDataSource()
        {
            _view.ProductList = string.IsNullOrWhiteSpace(_view.Keyword)
                ? _productList
                : _productList.FindAll(p => (p.Barcode != null && p.Barcode.EndsWith(_view.Keyword)) ||
                    _view.Keyword.Equals(p.Barcode) ||
                    p.Specification.ToLower().Contains(_view.Keyword));
        }

        public void AddProductToCart()
        {
            var product = _productList.Find(p => p.ProductId.Equals(_view.SelectedProductId));
            _cartList.Add(product);
            UpdateCart();
            UpdateDisplay();
        }

        public void UpdateCart()
        {
            _view.ClearGrid();
            foreach (var product in _cartList.Distinct())
            {
                var amount = _cartList.Count(p => p.ProductId.Equals(product.ProductId));
                _view.AddProductToGrid(product, amount);
            }

            UpdateDisplay();
            _view.CanSell = _cartList.Count > 0;
        }

        public void RemoveProduct(Product product)
        {
            _cartList.Remove(product);
        }

        public void RemoveAllProduct(Product product)
        {
            _cartList.RemoveAll(p => p.ProductId == product.ProductId);
        }

        public void AddProduct(Product product)
        {
            _cartList.Add(product);
        }

        private decimal CalculateDiscount()
        {
            if (!_view.IsDiscountEnabled) return 0;
            return _view.IsPercentageSelectorChecked
                ? GetBaseAmount() * _view.DiscountPercentage
                : _view.CashDiscount;
        }
        private decimal CalculateTotalSalePrice()
        {
            return GetBaseAmount() - CalculateDiscount();
        }

        private decimal GetBaseAmount() => _cartList.Sum(p => p.Price);
        public void UpdateDisplay()
        {
            _view.TotalSalePrice = CalculateTotalSalePrice();
            PointOfSale.Instance.PaymentGateway.AmountToPay = _view.TotalSalePrice;
        }

        public void Reset()
        {
            _cartList.Clear();
            UpdateCart();
            UpdateDisplay();
        }

        public void Sell()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var sale = database.Sale.Add(new Sale
                {
                    EventDate = DateTime.Now,
                    EmployeeId = _view.EmployeeList[_view.SelectedEmployee].EmployeeId,
                    CustomerId = _view.CustomerId,
                    Discount = CalculateDiscount(),
                });

                foreach (var item in _cartList.Distinct())
                    sale.SaleDetail.Add(new SaleDetail
                    {
                        ProductName = item.Specification,
                        Amount = _cartList.Count(i => i.Equals(item)),
                        SalePrice = item.Price
                    });
                database.Sale.Add(sale);
                database.SaveChanges();
                PointOfSale.Instance.PaymentGateway.SaleToPay = sale;
                PointOfSale.Instance.PaymentGateway.Transact();
            }
            DecreaseInventory();
            Notify();
        }

        private void DecreaseInventory()
        {
            using (var database = new AromasDatabaseEntities())
            {
                foreach (var item in _cartList.Distinct().Where(i => i.Category.Equals("P")))
                {
                    var product = database.Product.Find(item.ProductId);
                    var amount = _cartList.Count(p => p.Equals(item));
                    if (product.InventoryAmount >= amount) product.InventoryAmount -= amount;
                    else product.InventoryAmount = 0;
                }
                database.SaveChanges();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(this);
        }
    }
}