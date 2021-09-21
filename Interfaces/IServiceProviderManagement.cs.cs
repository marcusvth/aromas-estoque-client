using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromasEstoque
{
    public interface IServiceProviderManagement
    {
        bool IsDeleting { get; }
        bool IsEditing { get; }
        object ProviderDataSource { set; }
        int SelectedProviderId { get; set; }
        void SetController(ServiceProviderController controller);
    }
}
