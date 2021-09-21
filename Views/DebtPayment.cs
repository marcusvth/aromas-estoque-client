using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class DebtPayment : MetroForm
    {
        public readonly PaymentGatewayControl PaymentGateway = new PaymentGatewayControl();
        public DebtPayment(Sale sale, decimal amountToPay)
        {
            InitializeComponent();
            ConfigStartup();
            PaymentGateway.SaleToPay = sale;
            PaymentGateway.AmountToPay = amountToPay;
            Text = $@"Pagamento de venda nº {sale.SaleId}";
        }

        private void ConfigStartup()
        {
            paymentMethodPanel.Controls.Add(PaymentGateway);
            PaymentGateway.ShowPayButton = true;
            PaymentGateway.PayButton.Click += PayButton_Click;
        }

        public DebtPayment(Job job, decimal amountToPay)
        {
            InitializeComponent();
            ConfigStartup();
            PaymentGateway.JobToPay = job;
            PaymentGateway.AmountToPay = amountToPay;

            Text = $@"Pagamento de serviço nº {job.JobId}";
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}