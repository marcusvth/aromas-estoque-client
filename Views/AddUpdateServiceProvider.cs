using System;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddUpdateServiceProvider : MetroForm
    {
        int _providerId;
        public AddUpdateServiceProvider()
        {
            InitializeComponent();
        }

        public AddUpdateServiceProvider(int providerId)
        {
            _providerId = providerId;
            InitializeComponent();
            Text = "Editando prestador de serviço";
            okButton.Text = @"Salvar";
            okButton.Enabled = true;
            LoadProviderData();
        }

        private void LoadProviderData()
        {
            var provider = ServiceProviderManagement.Instance.Controller.GetSingleProvider(_providerId);
            nameInput.Text = provider.FullName;
        }

        private void AddProvider()
        {
            using (var database = new AromasDatabaseEntities())
            {
                ServiceProviderManagement.Instance.Controller.AddProvider(nameInput.Text);
            }
        }

        private void UpdateProvider()
        {
            ServiceProviderManagement.Instance.Controller.UpdateProvider(_providerId, nameInput.Text);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_providerId is 0) AddProvider();
            else UpdateProvider();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            var isNameValid = nameInput.Text.Length > 0;
            okButton.Enabled = isNameValid;
        }
    }
}