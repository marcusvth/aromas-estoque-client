using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class Sales : MetroForm
    {
        private int _lastSelectedRow;
        private static Sales _sales;

        public static Sales GetInstance()
        {
            if (_sales is null) _sales = new Sales();
            return _sales.IsDisposed ? _sales = new Sales() : _sales;
        }
        public Sales()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            var database = new AromasDatabaseEntities();

            var sales = database.Sale
                .OrderByDescending(s => s.EventDate).Take(100)
                .Select(s => new
                {
                    s.SaleId,
                    Employee = s.Employee.FullName,
                    Customer = s.Customer.FullName ?? "Cliente não identificado",
                    s.EventDate,
                    Total = s.SaleDetail.Sum(d => d.SalePrice * d.Amount) - s.Discount
                });

            salesGrid.DataSource = sales.ToList();


            if (salesGrid.RowCount is 0 || salesGrid.RowCount <= _lastSelectedRow) return;
            salesGrid.CurrentCell = salesGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void Sales_Shown(object sender, EventArgs e)
        {
            //UpdateGrid();
        }

        private void SalesGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = salesGrid.Columns[e.ColumnIndex].Name == "Delete";
            if (!isDeleting || e.RowIndex < 0) return;
            var saleId = int.Parse(salesGrid.Rows[e.RowIndex].Cells["SaleId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            DeleteSale(saleId);
        }

        private void DeleteSale(int saleId)
        {
            var deleteConfirmation = MessageBox.Show(
                $@"Excluindo venda {saleId}. Todos os pagamentos associados à ela serão excluídos. Deseja continuar?",
                @"Excluir venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deleteConfirmation != DialogResult.Yes) return;

            using (var database = new AromasDatabaseEntities())
            {
                var sale = database.Sale.Find(saleId);
                database.Transactions.RemoveRange(sale.Transactions);
                database.SaleDetail.RemoveRange(sale.SaleDetail);
                database.Sale.Remove(sale);
                database.SaveChanges();
            }

            UpdateGrid();
        }

        private void Sales_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}