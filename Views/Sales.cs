using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class Sales : MetroForm, IObserver, ISubject
    {
        private int _lastSelectedRow;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private static Sales _instance;

        public static Sales Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new Sales() : _instance;
            }
        }

        public Sales()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            var database = new AromasDatabaseEntities();

            var sales = database.Sale
                .OrderByDescending(s => s.EventDate).Take(100).ToList();
            var datasource = sales
                .Select(s => new
                {
                    s.SaleId,
                    Employee = s.Employee?.FullName ?? "Removido do sistema.",
                    Customer = s.Customer?.FullName ?? "Cliente não identificado",
                    s.EventDate,
                    Total = s.SaleDetail.Sum(d => d.SalePrice * d.Amount) - s.Discount
                });

            salesGrid.DataSource = datasource.ToList();


            if (salesGrid.RowCount is 0 || salesGrid.RowCount <= _lastSelectedRow) return;
            salesGrid.CurrentCell = salesGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void Sales_Shown(object sender, EventArgs e)
        {
            UpdateGrid();
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
            Notify();
        }

        public void Update(ISubject subject)
        {
            UpdateGrid();
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

        private void Sales_Load(object sender, EventArgs e)
        {
            Attach(PendingPayments.Instance.Controller);
            Attach(TransactionsDashboard.Instance.Controller);
        }
    }
}