using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class CustomerManagement : MetroForm
    {
        private int _lastSelectedRow;
        private static CustomerManagement _customerManagement;

        public static CustomerManagement GetInstance()
        {
            if (_customerManagement is null) _customerManagement = new CustomerManagement();
            return _customerManagement.IsDisposed ? _customerManagement = new CustomerManagement() : _customerManagement;
        }
        public CustomerManagement()
        {
            InitializeComponent();
            UpdateCustomerGrid();
        }

        public void UpdateCustomerGrid()
        {
            var database = new AromasDatabaseEntities();
            var customer = database.Customer.Select(c => new
            {
                c.CustomerId,
                c.FullName,
                c.PhoneNumber
            });

            customerGrid.DataSource = customer.ToList();

            if (customerGrid.RowCount is 0 || customerGrid.RowCount <= _lastSelectedRow) return;
            customerGrid.CurrentCell = customerGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void DeleteCustomer(int customerId)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var customer = database.Customer.Find(customerId);
                var confirmationResult = MessageBox.Show(
                    $"Você está prestes a excluir o cliente \"{customer.FullName}\". Tem certeza disto?",
                    @"Excluindo cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmationResult != DialogResult.Yes) return;
                database.Customer.Remove(customer);
                database.SaveChanges();
            }

            UpdateCustomerGrid();
        }

        private void EditCustomer(int customerId)
        {
            var editCustomer = new AddUpdateCustomer(customerId);
            if (editCustomer.ShowDialog() == DialogResult.OK)
                UpdateCustomerGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddUpdateCustomer();
            if (addCustomer.ShowDialog() == DialogResult.OK)
                UpdateCustomerGrid();
        }

        private void CustomerGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = customerGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = customerGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            var customerId = int.Parse(customerGrid.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            if (isEditing)
                EditCustomer(customerId);
            if (isDeleting)
                DeleteCustomer(customerId);
        }
        private void CustomerManagement_Activated(object sender, EventArgs e)
        {
            UpdateCustomerGrid();
        }
    }
}