using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddService : MetroForm
    {
        public PaymentGatewayControl PaymentGateway;
        public CustomerSelectorControl CustomerSelector;
        public AddService()
        {
            InitializeComponent();
            PaymentGateway = new PaymentGatewayControl { ShowPayButton = false };
            paymentPanel.Controls.Add(PaymentGateway);
            CustomerSelector = new CustomerSelectorControl();
            customerPanel.Controls.Add(CustomerSelector);
        }

        private void UpdateProviderList()
        {
            var database = new AromasDatabaseEntities();
            var providerList =
                database.ServiceProvider.Select(provider => provider.ProviderId + " - " + provider.FullName);
            providerSelector.DataSource = providerList.ToList();
        }
        private void PriceInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            priceInput.Monify(e);
        }

        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            CreateService();
        }
        private int? GetProviderId()
        {
            return int.Parse(providerSelector.Text.Split('-')[0].Trim());
        }
        private void CreateService()
        {

            if (PaymentGateway.TotalPaidAmount < PaymentGateway.AmountToPay && CustomerSelector.SelectedCustomerId is null)
            {
                MetroMessageBox.Show(this, "Por favor, identifique o cliente antes de fazer o pagamento parcial.",
                  "Identifique o cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }

            if (PaymentGateway.AmountToPay > PaymentGateway.TotalPaidAmount)
                MetroMessageBox.Show(this, @"O restante do valor será listado como pagamento pendente.",
                    "Pagamento parcial");
            using (var database = new AromasDatabaseEntities())
            {
                var job = database.Job.Add(new Job
                {
                    ProviderId = GetProviderId(),
                    CustomerId = CustomerSelector.SelectedCustomerId,
                    TotalPrice = decimal.Parse(priceInput.Text),
                    EventDate = DateTime.Now,
                    Specification = descriptionInput.Text
                });

                database.SaveChanges();

                PaymentGateway.JobToPay = job;

                PaymentGateway.Transact();
            }
        }

        private void AddService_Shown(object sender, EventArgs e)
        {
            UpdateProviderList();
        }

        private void PriceInput_TextChanged(object sender, EventArgs e)
        {
            PaymentGateway.AmountToPay = decimal.Parse(priceInput.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DescriptionInput_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = descriptionInput.Text.Length > 0;
        }
    }
}
