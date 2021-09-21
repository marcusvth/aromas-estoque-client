namespace AromasEstoque
{
    public interface IPendingPayments
    {
        object DataSource { set; }
        bool FilterByCustomer { get; }
        decimal TotalCustomerDebtAmount { set; }
        short? SelectedCustomerId { get; }
        int SelectedPayableId { get; }
        bool IsJobSelected { get; }
    }
}