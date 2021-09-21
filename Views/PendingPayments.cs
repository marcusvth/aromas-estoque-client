using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class PendingPayments : MetroForm, IPendingPayments
    {
        private static PendingPayments _instance;
        public PendingPaymentsController Controller;
        private CustomerSelectorControl _customerSelector;
        public object DataSource { set => pendingGrid.DataSource = value; }
        public bool FilterByCustomer => filterByCustomerSelector.Checked;
        public decimal TotalCustomerDebtAmount { set => totalCustomerDebtDisplay.Text = $@"Débito total: {value:C}"; }
        public short? SelectedCustomerId => _customerSelector?.SelectedCustomerId ?? 0;
        public int SelectedPayableId { get; private set; }
        public bool IsJobSelected { get; private set; }
        public static PendingPayments Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new PendingPayments() : _instance;
            }
        }
        private PendingPayments()
        {
            InitializeComponent();
            pendingGrid.AutoGenerateColumns = false;
            Controller = new PendingPaymentsController(this);
            _customerSelector = new CustomerSelectorControl {SelectOnlyMode = true};
            _customerSelector.Selector.SelectedIndexChanged += Selector_SelectedIndexChanged;
            customerPanel.Controls.Add(_customerSelector);
        }

        private void Selector_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Controller.UpdateDisplay();
        }

        private void PendingGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (pendingGrid.Columns[e.ColumnIndex].Name != "Pay" || e.RowIndex < 0) return;
            var whatIsBeingPaid = pendingGrid.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            SelectedPayableId = int.Parse(pendingGrid.Rows[e.RowIndex].Cells["RefId"].Value.ToString());
            IsJobSelected = whatIsBeingPaid.Equals("Serviço");
            Controller.PayDebt();
        }

        private void FilterByCustomerSelector_CheckedChanged(object sender, System.EventArgs e)
        {
            customerPanel.Enabled = filterByCustomerSelector.Checked;
            totalCustomerDebtDisplay.Visible = filterByCustomerSelector.Checked;
            Controller.UpdateDisplay();
        }
        private void pendingGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (pendingGrid.Rows.Count is 0 || e.RowIndex < 0) return;
            var payableId = int.Parse(pendingGrid.Rows[e.RowIndex].Cells["RefId"].Value.ToString());
            var category = pendingGrid.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            pendingGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = category.Equals("Serviço")
                ? Controller?.GetJobItems(payableId)
                : Controller?.GetSaleItems(payableId);
        }

        private void pendingGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            pendingGrid.Enabled = pendingGrid.Rows.Count > 0;
        }
    }
}