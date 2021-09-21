using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AromasEstoque.Controllers;
using MetroFramework.Controls;

namespace AromasEstoque
{
    public partial class PaymentGatewayControl : UserControl, IObserver, ISubject, IPaymentController
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public readonly PaymentGatewayController Controller;
        private decimal _returnAmount;
        private decimal _amountToPay;
        public PaymentGatewayControl()
        {
            InitializeComponent();
            Controller = new PaymentGatewayController(this);
            parcelSelector.SelectedIndex = 0;
        }

        public Sale SaleToPay { get; set; }
        public Job JobToPay { get; set; }
        public bool CreditCardEnabled => creditSelector.Checked;
        public bool DebitCardEnabled => debitSelector.Checked;
        public bool MoneyEnabled => moneySelector.Checked;
        public decimal DebitCardAmount => DebitCardEnabled ? decimal.Parse(debitInput.Text) : 0;
        public decimal CreditCardAmount => CreditCardEnabled? decimal.Parse(creditInput.Text) : 0;
        public decimal MoneyAmount => MoneyEnabled? decimal.Parse(moneyInput.Text) : 0;
        public decimal TotalPaidAmount => CreditCardAmount + DebitCardAmount + MoneyAmount;
        public bool ShowPayButton
        {
            set => payButton.Visible = value;
        }
        public MetroButton PayButton => payButton;

        public decimal AmountToPay
        {
            get => _amountToPay;
            set
            {
                _amountToPay = value;
                Controller.UpdateDisplay();
                amountToPayDisplay.Text = $@"Total a pagar: {value:C}";
            }
        }

        public decimal ReturnAmount
        {
            get => _returnAmount;
            set
            {
                _returnAmount = value;
                returnAmountDisplay.Text = $@"Troco: {value:C}";
            }
        }
        public byte Parcel => (byte) (parcelSelector.SelectedIndex + 1);
        
        private void PaidInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PaidInput_KeyDown(object sender, KeyEventArgs e)
        {
            ((MetroTextBox)sender).Monify(e);
            Controller.UpdateDisplay();
        }

        public void Update(ISubject subject)
        {
            throw new NotImplementedException();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(this);
        }

        private void MethodCheck_CheckedChanged(object sender, EventArgs e)
        {
            moneyInput.Enabled = moneySelector.Checked;
            debitInput.Enabled = debitSelector.Checked;
            creditInput.Enabled = creditSelector.Checked;
            parcelSelector.Enabled = creditSelector.Checked;
            Controller.UpdateDisplay();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            Transact();
        }

        public void Transact()
        {
            if (JobToPay is null)
                Controller.Transact(SaleToPay);
            else Controller.Transact(JobToPay);

            SaleToPay = null;
            JobToPay = null;
            ZeroFillInputs();
        }

        private void ZeroFillInputs()
        {
            moneyInput.Text = "0,00";
            debitInput.Text = "0,00";
            creditInput.Text = "0,00";
        }
    }
}