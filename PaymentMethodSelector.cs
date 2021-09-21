using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AromasEstoque
{
    public partial class PaymentMethodSelector : UserControl
    {
        private List<Customer> _customers;
        private decimal _returnAmount;
        public PaymentMethodSelector()
        {
            InitializeComponent();
            parcelSelector.SelectedIndex = 0;
            GetCustomerList();
        }

        public decimal PaidAmount
        {
            set => PaidAmountInput.Text = value.ToString("0.00");
            get => decimal.Parse(PaidAmountInput.Text);
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
        public string PaymentMethod { get; set; } = "M";

        public byte Parcel => (byte) (PaymentMethod == "C" ? parcelSelector.SelectedIndex + 1 : 0);

        public Customer Purchaser
        {
            get
            {
                using (var database = new AromasDatabaseEntities())
                {
                    return notIdenfityCustomerCheck.Checked
                        ? null
                        : database.Customer.FirstOrDefault(c =>
                            c.FullName.Equals(customerSelector.SelectedValue.ToString()));
                }
            }
        }

        public bool ShowCustomerInfo
        {
            set
            {
                customerOnlyPanel.Enabled = value;
                customerOnlyPanel.Visible = value;
                if (!value) Height = 190;
            }
        }

        public MetroTextBox PaidAmountInput => paidAmountInput;

        public bool IdentifyCustomer => !notIdenfityCustomerCheck.Checked;

        private void GetCustomerList()
        {
            var database = new AromasDatabaseEntities();
            var customers = database.Customer;
            _customers = customers.ToList();
            customerSelector.DataSource = _customers.Select(customer => customer.FullName).ToList();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddUpdateCustomer();
            if (addCustomer.ShowDialog() == DialogResult.OK)
                GetCustomerList();
        }

        private void PaidInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PaidInput_KeyDown(object sender, KeyEventArgs e)
        {
            PaidAmountInput.Monify(e);
        }

        private void UndefinedCustomer_CheckedChanged(object sender, EventArgs e)
        {
            var customerControls = new Control[] {customerHeader, customerSelector, addButton};

            foreach (var control in customerControls) control.Visible = !notIdenfityCustomerCheck.Checked;
        }

        private void PaymentSelector_CheckedChanged(object sender, EventArgs e)
        {
            switch (((MetroRadioButton) sender).Name)
            {
                case "moneySelector":
                    PaymentMethod = "M";
                    break;
                case "debitSelector":
                    PaymentMethod = "D";
                    break;
                case "creditSelector":
                    PaymentMethod = "C";
                    break;
            }

            parcelSelector.Enabled = creditSelector.Checked;
        }
    }
}