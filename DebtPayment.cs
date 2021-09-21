using System;
using System.Linq;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class DebtPayment : MetroForm
    {
        private readonly PaymentMethodSelector _paymentMethodSelector = new PaymentMethodSelector();
        private readonly int _saleId;
        private decimal _totalPrice;

        public DebtPayment(int saleId)
        {
            _saleId = saleId;
            InitializeComponent();
            paymentMethodPanel.Controls.Add(_paymentMethodSelector);
            _paymentMethodSelector.ShowCustomerInfo = false;
            _paymentMethodSelector.PaidAmountInput.TextChanged += AmountPaid_TextChanged;
            Text = $@"Pagamento de venda nº {saleId}";
            LoadSale();
        }

        private decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                _totalPrice = value;
                pendingAmountDisplay.Text = $@"{value:C} restantes de {value:C}";
            }
        }

        private void LoadSale()
        {
            var database = new AromasDatabaseEntities();
            var sale = database.Sale.Find(_saleId);
            TotalPrice = sale.SaleDetail.Sum(d => d.SalePrice * d.Amount) - sale.Discount -
                         sale.Transactions.Sum(s => s.Amount);
        }

        private void AmountPaid_TextChanged(object sender, EventArgs e)
        {
            pendingAmountDisplay.Text = _paymentMethodSelector.PaidAmount > TotalPrice
                    ? $@"{0:C} restantes de {_totalPrice:C}"
                : $@"{TotalPrice - _paymentMethodSelector.PaidAmount:C} restantes de {_totalPrice:C}";
            payDebtButton.Enabled = _paymentMethodSelector.PaidAmount > 0;

            _paymentMethodSelector.ReturnAmount = _paymentMethodSelector.PaidAmount < TotalPrice
                ? 0
                : _paymentMethodSelector.PaidAmount - TotalPrice;
        }

        private void PayDebtButton_Click(object sender, EventArgs e)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var sale = database.Sale.Find(_saleId);
                sale.Transactions.Add(new Transactions
                {
                    Amount = _paymentMethodSelector.PaidAmount,
                    Category = "S",
                    Comment = $"Recebimento de venda nº {_saleId}",
                    Currency = _paymentMethodSelector.PaymentMethod,
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                    EventDate = DateTime.Now,
                    ReturnAmount = _paymentMethodSelector.PaidAmount < TotalPrice
                        ? 0
                        : _paymentMethodSelector.PaidAmount - TotalPrice,
                    Parcel = _paymentMethodSelector.Parcel
                });
                database.SaveChanges();
            }

            Close();
        }
    }
}