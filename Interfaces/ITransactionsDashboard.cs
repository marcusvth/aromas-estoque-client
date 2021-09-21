using System;
using System.Collections.Generic;

namespace AromasEstoque
{
    public interface ITransactionsDashboard
    {
        object DataSource { set; }
        decimal TotalIncome { get; set; }
        decimal TotalOutflow { get; set; }
        decimal Balance { set; }
        decimal TotalDebit { get; set; }
        decimal TotalCredit { get; set; }
        decimal TotalMoney { get; set; }
        void SelectLastSelectedRow();
        int SelectedReport { get; }
        int SelectedTransactionId { get; }
        DateTime FromReportDate { get; }
        DateTime ToReportDate { get; }
        decimal VaultAmount { set; }
    }
}