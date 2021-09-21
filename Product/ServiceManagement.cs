using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class ServiceManagement : MetroForm
    {
        private int _lastSelectedRow;
        private static ServiceManagement _serviceManagement;
        public ServiceManagement()
        {
            InitializeComponent();
            UpdateServiceGrid();
        }
        public static ServiceManagement GetInstance()
        {
            if (_serviceManagement is null) _serviceManagement = new ServiceManagement();
            return _serviceManagement.IsDisposed ? _serviceManagement = new ServiceManagement() : _serviceManagement;
        }
        private void ServiceGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = serviceGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = serviceGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            var serviceId = int.Parse(serviceGrid.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            if (isEditing)
                EditService(serviceId);
            if (isDeleting)
                DeleteService(serviceId);
        }

        private void UpdateServiceGrid()
        {
            var database = new AromasDatabaseEntities();
            var services = database.Product.Where(p => p.Category == "S").OrderBy(p => p.Specification).Select(
                service =>
                    new
                    {
                        service.ProductId,
                        service.Specification,
                        service.Price
                    });

            serviceGrid.DataSource = services.ToList();


            if (serviceGrid.RowCount is 0 || serviceGrid.RowCount <= _lastSelectedRow) return;
            serviceGrid.CurrentCell = serviceGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void DeleteService(int serviceId)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var service = database.Product.Find(serviceId);
                var confirmationResult = MessageBox.Show(
                    $"Você está prestes a excluir o serviço \"{service.Specification}\". Tem certeza disto?",
                    @"Excluindo serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmationResult != DialogResult.Yes) return;
                database.Product.Remove(service);
                database.SaveChanges();
            }

            UpdateServiceGrid();
        }

        private void EditService(int serviceId)
        {
            var editService = new AddUpdateService(serviceId);
            if (editService.ShowDialog() == DialogResult.OK)
                UpdateServiceGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addService = new AddUpdateService();
            if (addService.ShowDialog() == DialogResult.OK)
                UpdateServiceGrid();
        }
    }
}