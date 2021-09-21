using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    // Set ShadowType to something else "None" will make the window don't get focus when clicked 1st time.
    public partial class MainDashboard : MetroForm
    {
        public static List<byte> AllowedEmployeeIds = new List<byte> { 1, 6 };
        public static bool IsActionAllowed;
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
            IsActionAllowed = AllowedEmployeeIds.Contains(CurrentEmployee.EmployeeId);
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            _productManagement = ProductManagement.Instance;
            OpenForm(_productManagement);
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            _serviceManagement = ServiceManagement.Instance;
            OpenForm(_serviceManagement);
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            _employeeManagement = EmployeeManagement.Instance;
            OpenForm(_employeeManagement);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            _transactionsDashboard = TransactionsDashboard.Instance;
            OpenForm(_transactionsDashboard);
        }

        private void StartPointOfSaleButton_Click(object sender, EventArgs e)
        {
            _pointOfSale = PointOfSale.Instance;
            OpenForm(_pointOfSale);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {

            _sales = Sales.Instance;
            OpenForm(_sales);
        }
        private void PendingPaymentsButton_Click(object sender, EventArgs e)
        {
           
            _pendingPayments = PendingPayments.Instance;
            OpenForm(_pendingPayments);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            _customerManagement = CustomerManagement.Instance;
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