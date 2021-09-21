using System.Collections.Generic;

namespace AromasEstoque
{
    public interface IPointOfSale
    {
        List<Product> ProductList { get; set; }
        decimal TotalSalePrice { get; set; }
        decimal DiscountPercentage { get; }
        List<Employee> EmployeeList { get; set; }
        int SelectedEmployee { get; }
        decimal CashDiscount { get; }
        bool IsDiscountEnabled { get; }
        bool IsPercentageSelectorChecked { get; }
        int SelectedProductId { get; }
        short? CustomerId { get; }
        bool CanSell { set; }
        string Keyword { get; }
        void AddProductToGrid(Product product, int amount = 1);
        void ClearGrid();
    }
}