using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class PointOfSale : MetroForm, IPointOfSale, IObserver
    {
        public PaymentGatewayControl PaymentGateway;
        public CustomerSelectorControl CustomerSelector;
        private readonly Timer _timer = new Timer();
        private PointOfSaleController _presenter;
        private List<Product> _productList;
        private static int _selectedEmployee = -1;
        private static List<Employee> _employeeList = new List<Employee>();

        public List<Employee> EmployeeList
        {
            get => _employeeList;
            set
            {
                _employeeList = value;
                employeeSelector.DataSource = value.Select(employee => employee.FullName).ToList();
            }
        }

        public int SelectedEmployee => employeeSelector.SelectedIndex;

        private decimal _totalSalePrice;

        // Making this form a Singleton to avoid multiple instances

        private static PointOfSale _instance;
        public static PointOfSale Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new PointOfSale() : _instance;
            }
        }

        public PointOfSale()
        {
            InitializeComponent();
            SetController();
            PaymentGateway = new PaymentGatewayControl();
            CustomerSelector = new CustomerSelectorControl();
            paymentPanel.Controls.Add(PaymentGateway);
            customerPanel.Controls.Add(CustomerSelector);
            PaymentGateway.ShowPayButton = false;
            saleNavigation.SelectedTab = newSalePage;
            employeeSelector.SelectedIndex = _selectedEmployee is -1
                ? _employeeList.FindIndex(e=> e.EmployeeId == MainDashboard.CurrentEmployee.EmployeeId) 
                : _selectedEmployee;
        }


        public List<Product> ProductList
        {
            get => _productList;
            set
            {
                _productList = value;
                productSelector.DataSource = value.Select(p => $"{p.ProductId} - {p.Specification}").ToList();
            }
        }

        public short? CustomerId => CustomerSelector.SelectedCustomerId;

        public bool CanSell
        {
            set => finishSaleButton.Enabled = value;
        }
        public decimal TotalSalePrice
        {
            get => _totalSalePrice;
            set
            {
                _totalSalePrice = value;
                totalPriceDisplay.Text = $@"Total: {value:C}";
            }
        }

        public decimal PaidAmount => PaymentGateway.TotalPaidAmount;
        public decimal DiscountPercentage => discountPercentageInput.Value / 100;
        public decimal CashDiscount => decimal.Parse(moneyDiscountInput.Text);
        public bool IsPercentageSelectorChecked => percentDiscountSelector.Checked;
        public bool IsDiscountEnabled => discountToggle.Checked;

        public int SelectedProductId
        {
            get
            {
                var productId = productSelector.SelectedValue.ToString().Split('-')?[0]?.Trim();
                return int.Parse(productId);
            }
        }

        public string Keyword => searchInput.Text.ToLower();

        public void AddProductToGrid(Product product, int amount = 1)
        {
            cartGrid.Rows.Add(product.ProductId, product.Specification, null, amount, null, product.Price,
                amount * product.Price);
        }

        public void ClearGrid()
        {
            cartGrid.Rows.Clear();
        }

        public void ShowSuccessfulSale()
        {
            saleNavigation.SelectedTab = newSalePage;
            successPicture.Visible = true;
            _timer.Interval = 3400;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void SetController()
        {
            _presenter = new PointOfSaleController(this);
        }

        private void ProductInput_TextChanged(object sender, EventArgs e)
        {
            _presenter.SetDataSource();
        }

        public Product GetClickedProduct(int productId)
        {
            return _productList.Find(p => p.ProductId.Equals(productId));
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (productSelector.SelectedIndex < 0) return;

            _presenter.AddProductToCart();
            _presenter.UpdateCart();
            searchInput.Clear();
            searchInput.Focus();
        }

        private void ProductsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.RowIndex < 0) return;
            var productId = (int)cartGrid.Rows[e.RowIndex].Cells[0].Value;
            var product = GetClickedProduct(productId);

            switch (e.ColumnIndex)
            {
                case 2:
                    _presenter.RemoveProduct(product);
                    break;
                case 4:
                    _presenter.AddProduct(product);
                    break;
                case 7:
                    _presenter.RemoveAllProduct(product);
                    break;
            }

            _presenter.UpdateCart();
            searchInput.Focus();
        }

        private void DiscountToggle_CheckedChanged(object sender, EventArgs e)
        {
            discountPanel.Visible = discountToggle.Checked;
            _presenter.UpdateDisplay();
        }

        private void DiscountSelectors_CheckedChanged(object sender, EventArgs e)
        {
            moneyDiscountInput.Enabled = moneyDiscountSelector.Checked;
            discountPercentageInput.Enabled = percentDiscountSelector.Checked;
            _presenter.UpdateDisplay();
        }


        private void PaymentMethodButton_Click(object sender, EventArgs e)
        {
            saleNavigation.SelectedTab = paymentTab;
        }

        private void MoneyInputs_HandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MoneyDiscountInput_KeyDown(object sender, KeyEventArgs e)
        {
            moneyDiscountInput.Monify(e);
        }

        private void MoneyInputs_InputChanged(object sender, EventArgs e)
        {
            _presenter.UpdateDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            successPicture.Visible = false;
            _timer.Stop();
        }

        private void CancelSaleButton_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show(@"Deseja cancelar a venda?", @"Cancelar venda", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
                ClearCurrentSale();
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || (searchInput.Text.Length != 13 && searchInput.Text.Length != 4)) return;
            if (productSelector.SelectedIndex < 0) return;
            _presenter.AddProductToCart();
            searchInput.Clear();
        }

        private void ClearCurrentSale()
        {
            _presenter.Reset();
            discountToggle.Checked = false;
            discountPercentageInput.Value = 0;
            moneyDiscountInput.Text = "0,00";
            moneyDiscountSelector.Checked = true;
            CustomerSelector.IdentifyCustomer = false;
        }

        public void Update(ISubject subject)
        {
            _presenter.UpdateProductList();
            _presenter.SetDataSource();
        }

        private void FinishSaleButton_Click(object sender, EventArgs e)
        {
            if (TotalSalePrice > PaidAmount && CustomerSelector.SelectedCustomerId is null)
            {
                MetroMessageBox.Show(this, "Por favor, identifique o cliente antes de fazer o pagamento parcial.",
                    "Identifique o cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TotalSalePrice > PaidAmount)
                MetroMessageBox.Show(this, @"O restante do valor será listado como pagamento pendente.",
                    "Pagamento parcial");
            _presenter.Sell();
            _presenter.Reset();
            ClearCurrentSale();
            ShowSuccessfulSale();
        }

        private void PointOfSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedEmployee = employeeSelector.SelectedIndex;
        }
    }
}