using System;
using System.Windows.Forms;
using AromasEstoque.Properties;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class TransactionsDashboard : MetroForm, ITransactionsDashboard
    {
        private static TransactionsDashboard _instance;
        public TransactionsController Controller;
        private int _lastSelectedRow;
        private decimal _totalIncome;
        private decimal _totalOutflow;
        private decimal _totalCredit;
        private decimal _totalDebit;
        private decimal _totalMoney;
        private TransactionsDashboard()
        {
            InitializeComponent();
            SetController();
        }

        public static TransactionsDashboard Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new TransactionsDashboard() : _instance;
            }
        }
        public decimal TotalIncome
        {
            get => _totalIncome;
            set
            {
                _totalIncome = value;
                incomeDisplay.Text = $@"Entrada total: {value:C}";
            }
        }

        public decimal TotalOutflow
        {
            get => _totalOutflow;
            set
            {
                _totalOutflow = value;
                OutflowDisplay.Text = $@"Saída total: {value:C}";
            }
        }

        public decimal Balance
        {
            set => balanceDisplay.Text = $@"Balanço: {value:C}";
        }

        public decimal TotalDebit
        {
            get => _totalDebit;
            set
            {
                _totalDebit = value;
                debitDisplay.Text = $@"Débito: {value:C}";
            }
        }

        public decimal TotalCredit
        {
            get => _totalCredit;
            set
            {
                _totalCredit = value;
                creditDisplay.Text = $@"Cartão de crédito: {value:C}";
            }
        }

        public decimal TotalMoney
        {
            get => _totalMoney;
            set
            {
                _totalMoney = value;
                moneyDisplay.Text = $@"Dinheiro: {value:C}";
            }
        }

        public int SelectedReport { get => reportSelector.SelectedIndex; }
        public DateTime FromReportDate { get => fromDatePicker.Value; }
        public DateTime ToReportDate { get => toDatePicker.Value; }

        public decimal VaultAmount
        {
            set => vaultDisplay.Text = $@"Total em caixa: {value:C}";
        }
        public object DataSource { set => transactionsGrid.DataSource = value; }

        public int SelectedTransactionId { get; set; }

        public void SelectLastSelectedRow()
        {
            if (transactionsGrid.RowCount is 0 || transactionsGrid.RowCount <= _lastSelectedRow) return;
            transactionsGrid.CurrentCell = transactionsGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void SetController()
        {
            Controller = new TransactionsController(this);
        }

        private void ToggleDateSelector()
        {
            dateSelectionPanel.Visible = reportSelector.SelectedIndex is 3;
        }

        private void ReportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleDateSelector();
            Controller.SetReport();
        }

        private void TransactionGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = transactionsGrid.Columns[e.ColumnIndex].Name == "Delete";
            if (!isDeleting || e.RowIndex < 0) return;
            SelectedTransactionId = int.Parse(transactionsGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            Controller.DeleteTransaction();
        }

        private void TransactionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (transactionsGrid.Columns[e.ColumnIndex].Name != "Flow") return;
            e.Value = (string) e.Value == "+" ? Resources.up_arrow : Resources.down_arrow;
        }

        private void TransactionsDashboard_Load(object sender, EventArgs e)
        {
            transactionsGrid.AutoGenerateColumns = false;
        }

        private void DatePicker_CloseUp(object sender, EventArgs e)
        {
            Controller.SetReport();
        }

        private void CashierOperationButton_Click(object sender, EventArgs e)
        {
            Controller.ShowCashierOperationsDialog();
        }

        private void IncomeDisplay_MouseEnter(object sender, EventArgs e)
        {
            incomeDetailsPanel.Visible = true;
        }

        private void IncomeDisplay_MouseLeave(object sender, EventArgs e)
        {
            incomeDetailsPanel.Visible = false;
        }
      
        private void TransactionsDashboard_Shown(object sender, EventArgs e)
        {
            reportSelector.SelectedIndex = 0;
            Controller.SetReport();
        }

        private void ComissionButton_Click(object sender, EventArgs e)
        {
            Controller.ShowComissionDialog();
        }
    }
}