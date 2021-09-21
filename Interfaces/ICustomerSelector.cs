using System.Collections.Generic;

namespace AromasEstoque
{
    public interface ICustomerSelector
    {
        List<string> DataSource { get; set; }
        int SelectedCustomerId { get; }
        bool IdentifyCustomer { get; }
    }
}