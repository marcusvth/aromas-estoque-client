using System.Collections.Generic;

namespace AromasEstoque
{
    public interface ITransactions
    {
        List<Transactions> DataSource { get; set; }
        decimal TotalIncome { get; set; }
        decimal TotalOutflow { get; set; }
        decimal Balance { set; }
        decimal TotalDebit { set; }
        decimal TotalCredit { get; set; }
        decimal TotalMoney { get; set; }
        decimal VaultAmount { set; }
    }
}