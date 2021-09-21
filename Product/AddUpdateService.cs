using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddUpdateService : MetroForm
    {
        private readonly int _serviceId = -1;

        public AddUpdateService()
        {
            InitializeComponent();
        }

        public AddUpdateService(int serviceId)
        {
            _serviceId = serviceId;
            InitializeComponent();
            okButton.Text = @"Salvar";
            okButton.Enabled = true;
            LoadServiceData();
        }

        private void LoadServiceData()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var service = database.Product.Find(_serviceId);
                descriptionInput.Text = service.Specification;
                priceInput.Text = service.Price.ToString();

                Text = $"Editando {service.Specification}";
            }
        }

        private void AddService()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Product.Add(new Product
                {
                    Specification = descriptionInput.Text,
                    Price = decimal.Parse(priceInput.Text),
                    Category = "S",
                    InventoryAmount = 0
                });

                database.SaveChanges();
            }
        }

        private void UpdateService()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var service = database.Product.Find(_serviceId);
                service.Specification = descriptionInput.Text;
                service.Price = decimal.Parse(priceInput.Text);
                database.SaveChanges();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_serviceId == -1) AddService();
            else UpdateService();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PriceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PriceInput_KeyDown(object sender, KeyEventArgs e)
        {
            priceInput.Monify(e);
        }

        private void PriceInput_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            var isDescriptionValid = descriptionInput.Text.Length > 0;
            var isPriceValid = decimal.Parse(priceInput.Text) > 0;

            okButton.Enabled = isPriceValid && isDescriptionValid;
        }
    }
}