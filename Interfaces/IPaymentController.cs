namespace AromasEstoque
{
    public interface IPaymentController
    {
        bool CreditCardEnabled { get; }
        bool DebitCardEnabled { get; }
        bool MoneyEnabled { get; }
        decimal DebitCardAmount { get; }
        decimal CreditCardAmount { get; }
        decimal MoneyAmount { get; }
        decimal ReturnAmount { set; }
        decimal AmountToPay { get; }
        byte Parcel { get; }
    }
}
