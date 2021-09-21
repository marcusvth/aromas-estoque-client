using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    // Set ShadowType to something else "None" will make the window don't get focus when clicked 1st time.
    public partial class MainDashboard : MetroForm
    {
        public static Employee CurrentEmployee;
        private CustomerManagement _customerManagement;
        private EmployeeManagement _employeeManagement;
        private PendingPayments _pendingPayments;
        private PointOfSale _pointOfSale;
        private ProductManagement _productManagement;
        private Sales _sales;
        private ServiceManagement _serviceManagement;
        private TransactionsDashboard _transactionsDashboard;

        public MainDashboard()
        {
            InitializeComponent();
            welcomeMessage.Text = $@"Bem vindo(a), {CurrentEmployee.FullName.Split(' ')[0]}!";
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            _productManagement = ProductManagement.GetInstance();
            OpenForm(_productManagement);
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            _serviceManagement = ServiceManagement.GetInstance();
            OpenForm(_serviceManagement);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            _employeeManagement = EmployeeManagement.GetInstance();
            OpenForm(_employeeManagement);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            _transactionsDashboard = TransactionsDashboard.GetInstance();
            OpenForm(_transactionsDashboard);
        }

        private void StartPointOfSaleButton_Click(object sender, EventArgs e)
        {
            _pointOfSale = PointOfSale.GetInstance();
            OpenForm(_pointOfSale);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {

            _sales = Sales.GetInstance();
            OpenForm(_sales);
        }
        private void PendingPaymentsButton_Click(object sender, EventArgs e)
        {
           
            _pendingPayments = PendingPayments.GetInstance();
            OpenForm(_pendingPayments);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            _customerManagement = CustomerManagement.GetInstance();
            OpenForm(_customerManagement);
        }

        private void OpenForm(Form form)
        {
            if (!form.Visible) form.Show();
            else form.BringToFront();
            form.WindowState = FormWindowState.Normal;
        }
    }
}