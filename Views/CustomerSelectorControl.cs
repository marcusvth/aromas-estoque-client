using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AromasEstoque
{
    public partial class CustomerSelectorControl : UserControl, IObserver
    {
        public short? SelectedCustomerId { get; set; }
        public MetroComboBox Selector => customerSelector;

        public bool IdentifyCustomer
        {
            set => notIdenfityCustomerCheck.Checked = !value;
            get => !notIdenfityCustomerCheck.Checked;
        }

        public bool SelectOnlyMode
        {
            set
            {
                if (value)
                    EnableSelectOnlyMode();
            }
        }
        public CustomerSelectorControl()
        {
            InitializeComponent();
            UpdateDataSource();
        }

        public void UpdateDataSource()
        {
            var database = new AromasDatabaseEntities();
            var customerList = database.Customer.OrderBy(c => c.FullName).Select(customer => customer.CustomerId + " - " + customer.FullName)
                .ToList();

            customerSelector.DataSource = customerList.ToList();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var addCustomer = new AddUpdateCustomer();
            if (addCustomer.ShowDialog() != DialogResult.OK) return;
            UpdateDataSource();
        }

        public void Update(ISubject subject)
        {
            UpdateDataSource();
        }

        private void NotIdenfityCustomerCheck_CheckedChanged(object sender, System.EventArgs e)
        {
            SetCustomerId();
            customerOnlyPanel.Visible = !notIdenfityCustomerCheck.Checked;
        }

        private void SetCustomerId()
        {
            SelectedCustomerId = notIdenfityCustomerCheck.Checked? (short?) null : short.Parse(customerSelector.Text.Split('-')[0].Trim());
        }

        private void CustomerSelector_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SetCustomerId();
        }
        private void EnableSelectOnlyMode()
        {
            addCustomerButton.Visible = false;
            customerSelector.Width = 611;
            customerOnlyPanel.Visible = true;
            notIdenfityCustomerCheck.Checked = false;
            notIdenfityCustomerCheck.Visible = false;
            Size = new Size(682, 73);
        }
    }
}
