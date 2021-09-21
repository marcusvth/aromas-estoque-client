using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class CustomerManagement : MetroForm, IObserver, ISubject
    {
        private int _lastSelectedRow;
        private static CustomerManagement _instance;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public static CustomerManagement Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new CustomerManagement() : _instance;
            }
        }
        private CustomerManagement()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
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

            UpdateGrid();
            Notify();
        }

        private void EditCustomer(int customerId)
        {
            var editCustomer = new AddUpdateCustomer(customerId);
            if (editCustomer.ShowDialog() != DialogResult.OK) return;
            UpdateGrid();
            Notify();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddUpdateCustomer();
            if (addCustomer.ShowDialog() != DialogResult.OK) return;
            UpdateGrid();
            Notify();
        }

        private void CustomerGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = customerGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = customerGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            var customerId = int.Parse(customerGrid.Rows[e.RowIndex].Cells["SelectedCustomerId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            if (isEditing)
                EditCustomer(customerId);
            if (isDeleting)
                DeleteCustomer(customerId);
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

        public void Update(ISubject subject)
        {
            if (subject is PaymentGatewayControl)
               UpdateGrid();
        }

        private void CustomerManagement_Shown(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            Attach(PointOfSale.Instance.PaymentGateway);
        }

        private void CustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Detach(PointOfSale.PaymentGateway);
        }
    }
}