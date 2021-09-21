using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class EmployeeManagement : MetroForm
    {
        private int _lastSelectedRow;
        private static EmployeeManagement _employeeManagement;
        public EmployeeManagement()
        {
            InitializeComponent();
            UpdateEmployeeGrid();
        }

        public static EmployeeManagement GetInstance()
        {
            if (_employeeManagement is null) _employeeManagement = new EmployeeManagement();
            return _employeeManagement.IsDisposed ? _employeeManagement = new EmployeeManagement() : _employeeManagement;
        }

        private void UpdateEmployeeGrid()
        {
            var database = new AromasDatabaseEntities();
            var employees = database.Employee.Select(employee => new
            {
                employee.EmployeeId,
                employee.FullName,
                employee.Username
            });

            employeeGrid.DataSource = employees.ToList();

            if (employeeGrid.RowCount is 0 || employeeGrid.RowCount <= _lastSelectedRow) return;
            employeeGrid.CurrentCell = employeeGrid.Rows[_lastSelectedRow].Cells[1];
        }

        private void DeleteEmployee(int employeeId)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var employee = database.Employee.Find(employeeId);
                var confirmationResult = MessageBox.Show(
                    $"Você está prestes a excluir o funcionário \"{employee.FullName}\". Tem certeza disto?",
                    @"Excluindo funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmationResult != DialogResult.Yes) return;
                database.Employee.Remove(employee);
                database.SaveChanges();
            }

            UpdateEmployeeGrid();
        }

        private void EditEmployee(int employeeId)
        {
            var editEmployee = new AddUpdateEmployee(employeeId);
            if (editEmployee.ShowDialog() == DialogResult.OK)
                UpdateEmployeeGrid();
        }

        private void EmployeeGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = employeeGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = employeeGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            var employeeId = int.Parse(employeeGrid.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString());
            _lastSelectedRow = e.RowIndex;
            if (isEditing)
                EditEmployee(employeeId);
            if (isDeleting)
                DeleteEmployee(employeeId);
        }
    }
}