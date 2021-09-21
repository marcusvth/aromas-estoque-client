using System.Collections.Generic;

namespace AromasEstoque
{
    public interface IPointOfSale
    {
        List<Product> ProductList { get; set; }
        decimal ReturnAmount { get; set; }
        decimal TotalSalePrice { get; set; }
        decimal DiscountPercentage { get; }
        decimal CashDiscount { get; }
        bool IsDiscountEnabled { get; }
        bool IsPercentageSelectorChecked { get; }
        decimal PaidAmount { get; set; }
        int SelectedProductId { get; }
        short? CustomerId { get; }
        byte Parcel { get; }
        bool CanSell { set; }
        string Keyword { get; }
        string PaymentMethod { get; }
        void AddProductToGrid(Product product, int amount = 1);
        void ClearGrid();
    }
}