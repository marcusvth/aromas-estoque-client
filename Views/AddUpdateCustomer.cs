using System;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddUpdateCustomer : MetroForm
    {
        private readonly int _customerId = -1;

        public AddUpdateCustomer()
        {
            InitializeComponent();
        }

        public AddUpdateCustomer(int customerId)
        {
            _customerId = customerId;
            InitializeComponent();
            LoadCustomerData();
            okButton.Text = @"Salvar";
            okButton.Enabled = true;
        }

        private void LoadCustomerData()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var customer = database.Customer.Find(_customerId);
                nameInput.Text = customer.FullName;
                phoneInput.Text = customer.PhoneNumber;

                Text = $@"Editando {customer.FullName}";
            }
        }

        private void AddCustomer()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Customer.Add(new Customer
                {
                    FullName = nameInput.Text,
                    PhoneNumber = phoneInput.Text
                });

                database.SaveChanges();
            }
        }

        private void UpdateCustomer()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var customer = database.Customer.Find(_customerId);
                customer.FullName = nameInput.Text;
                customer.PhoneNumber = phoneInput.Text;

                database.SaveChanges();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_customerId == -1) AddCustomer();
            else UpdateCustomer();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = nameInput.Text.Length > 0;
        }
    }
}