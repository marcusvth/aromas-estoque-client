namespace AromasEstoque
{
    public interface ICasherOperations
    {
        decimal Amount { get;  }
        string Comment { get; }
        bool IsReadjustment { get; }
        bool IsDeposit { get; }
    }
}