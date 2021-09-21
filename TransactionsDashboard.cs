using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AromasEstoque.Properties;
using Humanizer;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class TransactionsDashboard : MetroForm, ITransactions
    {
        private static TransactionsDashboard _transactionsDashboard;
        private TransactionsController _controller;
        private int _lastSelectedRow;
        private decimal _totalIncome;
        private decimal _totalOutflow;
        private decimal _totalCredit;
        private decimal _totalDebit;
        private decimal _totalMoney;

        private List<Transactions> _transactions = new List<Transactions>();

        public TransactionsDashboard()
        {
            InitializeComponent();
            SetController();
        }

        public static TransactionsDashboard GetInstance()
        {
            if (_transactionsDashboard is null) _transactionsDashboard = new TransactionsDashboard();
            return _transactionsDashboard.IsDisposed ? _transactionsDashboard = new TransactionsDashboard() : _transactionsDashboard;
        }

        public List<Transactions> DataSource
        {
            get => _transactions;
            set
            {
                _transactions = value;
                _controller.UpdateDetailedDisplay();
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

        public decimal VaultAmount
        {
            set => vaultDisplay.Text = $@"Total em caixa: {value:C}";
        } 

        public void UpdateGrid()
        {
            if (reportSelector.SelectedIndex is 3)
                _controller.GetTransactions(fromDatePicker.Value, toDatePicker.Value);
            else
                _controller.GetTransactions((TransactionsController.ReportType) reportSelector.SelectedIndex);

            var datasource = DataSource.OrderByDescending(x => x.EventDate).Select(transaction => new
            {
                Flow = transaction.Category == "S" || transaction.Category == "D" ? "+" : "-",
                Id = transaction.TransactionId,
                Employee = transaction.Employee.FullName,
                Information = transaction.SaleId is null? "R$ " + transaction.Amount + "  —  " +
                              transaction.Comment?.Transform(To.LowerCase, To.TitleCase)
                              : "R$ " + transaction.Amount + "  —  " + "Recebimento de venda nº " + transaction.Sale.SaleId,
                Currency = transaction.Currency == "C" ? "Cartão de crédito " + "(" + transaction.Parcel + "x)" :
                    transaction.Currency == "D" ? "Débito" : "Dinheiro",
                Date = transaction.EventDate
            });

            transactionsGrid.DataSource = datasource.ToList();
            if (transactionsGrid.RowCount is 0 || transactionsGrid.RowCount <= _lastSelectedRow) return;
            transactionsGrid.CurrentCell = transactionsGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void SetController()
        {
            _controller = new TransactionsController(this);
        }

        private void ToggleDateSelector()
        {
            dateSelectionPanel.Visible = reportSelector.SelectedIndex is 3;
        }

        private void ReportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleDateSelector();
            UpdateGrid();
        }

        private void DeleteTransaction(int transactionId)
        {
            var deleteConfirmation = MessageBox.Show($@"Excluindo o registro {transactionId}. Deseja continuar?",
                @"Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteConfirmation != DialogResult.Yes) return;
            _controller.DeleteTransaction(transactionId);
            UpdateGrid();
        }

        private void TransactionGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (transactionsGrid.Columns[e.ColumnIndex].Name != "Delete" || e.RowIndex < 0) return;
            var transactionId = int.Parse(transactionsGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            DeleteTransaction(transactionId);
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
            UpdateGrid();
        }

        private void CashierOperationButton_Click(object sender, EventArgs e)
        {
            var operation = new CashierOperations();
            if (operation.ShowDialog() != DialogResult.OK) return;
            UpdateGrid();
        }

        private void IncomeDisplay_MouseEnter(object sender, EventArgs e)
        {
            incomeDetailsPanel.Visible = true;
        }

        private void IncomeDisplay_MouseLeave(object sender, EventArgs e)
        {
            incomeDetailsPanel.Visible = false;
        }

        private void TransactionsDashboard_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}