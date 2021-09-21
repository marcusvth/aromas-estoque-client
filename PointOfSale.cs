using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace AromasEstoque
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public partial class PointOfSale : MetroForm, IPointOfSale
    {
        private readonly PaymentMethodSelector _paymentMethodSelector = new PaymentMethodSelector();
        private readonly Timer _timer = new Timer();
        private PointOfSaleController _controller;
        private List<Product> _productList;
        private static PointOfSale _pointOfSale;
        private decimal _totalSalePrice;

        public PointOfSale()
        {
            InitializeComponent();
            SetController(_controller);
            paymentMethodPanel.Controls.Add(_paymentMethodSelector);
            _paymentMethodSelector.ShowCustomerInfo = true;
            _paymentMethodSelector.PaidAmountInput.TextChanged += MoneyInputs_InputChanged;
        }


        public static PointOfSale GetInstance()
        {
            if (_pointOfSale is null) _pointOfSale = new PointOfSale();
            return _pointOfSale.IsDisposed ? _pointOfSale = new PointOfSale() : _pointOfSale;
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

        public bool CanSell
        {
            set => finishSaleButton.Enabled = value;
        }

        public decimal ReturnAmount
        {
            get => _paymentMethodSelector.ReturnAmount;
            set => _paymentMethodSelector.ReturnAmount = value;
        }

        public decimal TotalSalePrice
        {
            get => _totalSalePrice;
            set
            {
                _totalSalePrice = value;
                totalPriceDisplay.Text = $"Total: {value:C}";
            }
        }

        public decimal PaidAmount
        {
            get => _paymentMethodSelector.PaidAmount;
            set => _paymentMethodSelector.PaidAmount = value;
        }

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

        public string PaymentMethod => _paymentMethodSelector.PaymentMethod;

        public byte Parcel => _paymentMethodSelector.Parcel;

        public short? CustomerId => _paymentMethodSelector.Purchaser?.CustomerId;

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

        private void SetController(PointOfSaleController controller)
        {
            _controller = new PointOfSaleController(this);
        }

        private void ProductInput_TextChanged(object sender, EventArgs e)
        {
            _controller.GetProductList();
        }

        public Product GetClickedProduct(int productId)
        {
            return _productList.Find(p => p.ProductId.Equals(productId));
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (productSelector.SelectedIndex < 0) return;

            _controller.AddProductToCart();
            _controller.UpdateCart();
            searchInput.Clear();
            searchInput.Focus();
        }

        private void ProductsGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.RowIndex < 0) return;
            var productId = (int) cartGrid.Rows[e.RowIndex].Cells[0].Value;
            var product = GetClickedProduct(productId);

            switch (e.ColumnIndex)
            {
                case 2:
                    _controller.RemoveProduct(product);
                    break;
                case 4:
                    _controller.AddProduct(product);
                    break;
                case 7:
                    _controller.RemoveAllProduct(product);
                    break;
            }

            _controller.UpdateCart();
            searchInput.Focus();
        }

        private void DiscountToggle_CheckedChanged(object sender, EventArgs e)
        {
            discountPanel.Visible = discountToggle.Checked;
            _controller.UpdateDisplay();
        }

        private void DiscountSelectors_CheckedChanged(object sender, EventArgs e)
        {
            moneyDiscountInput.Enabled = moneyDiscountSelector.Checked;
            discountPercentageInput.Enabled = percentDiscountSelector.Checked;
            _controller.UpdateDisplay();
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

        private void FinishSaleButton_Click(object sender, EventArgs e)
        {
            var identifiedCustomer = _paymentMethodSelector.IdentifyCustomer;

            if (TotalSalePrice > PaidAmount && !identifiedCustomer)
            {
                MetroMessageBox.Show(this, "Por favor, identifique o cliente antes de fazer o pagamento parcial.",
                    "Identifique o cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TotalSalePrice > PaidAmount)
                MetroMessageBox.Show(this, @"O restante do valor será listado como pagamento pendente.",
                    "Pagamento parcial");
            _controller.Sell();
            _controller.Reset();
            ClearCurrentSale();
            ShowSuccessfulSale();
        }

        private void MoneyInputs_InputChanged(object sender, EventArgs e)
        {
            _controller.UpdateDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            successPicture.Visible = false;
            _timer.Stop();
        }

        private void CancelSaleButton_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Deseja cancelar a venda?", "Cancelar venda", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
                ClearCurrentSale();
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || searchInput.Text.Length != 13) return;
            if (productSelector.SelectedIndex < 0) return;
            _controller.AddProductToCart();
            searchInput.Clear();
        }

        private void ClearCurrentSale()
        {
            _controller.Reset();
            discountToggle.Checked = false;
            discountPercentageInput.Value = 0;
            moneyDiscountInput.Text = "0,00";
            moneyDiscountSelector.Checked = true;
            PaidAmount = 0;
        }
    }
}