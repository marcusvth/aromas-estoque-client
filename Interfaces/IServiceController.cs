using System;
using System.Collections.Generic;

namespace AromasEstoque
{
    public interface IServiceController
    {
        bool IsDeleting { get;  }
        DateTime FromDate { get; }
        DateTime ToDate { get; }
        decimal MonthlyIncome { set; }
        int SelectedJobId { get; set; }
        object ServiceDataSource { set; }
        bool FilterByDate { get; }
    }
}
