using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class PendingPayments : MetroForm
    {
        private static PendingPayments _pendingPayments;

        public static PendingPayments GetInstance()
        {
            if (_pendingPayments is null) _pendingPayments = new PendingPayments();
            return _pendingPayments.IsDisposed ? _pendingPayments = new PendingPayments() : _pendingPayments;
        }
        public PendingPayments()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            var database = new AromasDatabaseEntities();
            var pending = database.Sale.Where(s =>
                s.CustomerId != null && ((decimal?) s.Transactions.Sum(t => t.Amount) ?? 0) <
                s.SaleDetail.Sum(d => d.SalePrice * d.Amount) - s.Discount
            ).Select(s => new
            {
                s.SaleId,
                Customer = s.Customer.FullName,
                Total = s.SaleDetail.Sum(d => d.SalePrice * d.Amount) - s.Discount,
                PaidAmount = (decimal?) s.Transactions.Sum(t => t.Amount) ?? 0
            });

            pendingGrid.DataSource = pending.ToList();
        }

        private void PayDebt(int saleId)
        {
            var payDebt = new DebtPayment(saleId);
            payDebt.ShowDialog();
        }

        private void PendingGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (pendingGrid.Columns[e.ColumnIndex].Name != "Pay" || e.RowIndex < 0) return;
            var saleId = int.Parse(pendingGrid.Rows[e.RowIndex].Cells["SaleId"].Value.ToString());
            PayDebt(saleId);
            UpdateGrid();
        }

        private void PendingPayments_Activated(object sender, System.EventArgs e)
        {
            UpdateGrid();
        }
    }
}