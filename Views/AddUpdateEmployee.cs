using System;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class AddUpdateEmployee : MetroForm
    {
        private readonly int _employeeId = -1;

        public AddUpdateEmployee()
        {
            InitializeComponent();
        }

        public AddUpdateEmployee(int employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
            okButton.Text = @"Salvar";
            okButton.Enabled = true;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var employee = database.Employee.Find(_employeeId);

                nameInput.Text = employee.FullName;
                usernameInput.Text = employee.Username;
                passwordInput.Text = employee.PasswordHash;

                Text = $@"Editando {employee.FullName}";
            }
        }

        private void AddEmployee()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Employee.Add(new Employee
                {
                    FullName = nameInput.Text,
                    Username = usernameInput.Text,
                    PasswordHash = passwordInput.Text,
                    IsAdmin = adminToggle.Checked
                });
                database.SaveChanges();
            }
        }

        private void UpdateEmployee()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var employee = database.Employee.Find(_employeeId);

                employee.FullName = nameInput.Text;
                employee.Username = usernameInput.Text;
                employee.PasswordHash = passwordInput.Text;
                employee.IsAdmin = adminToggle.Checked;
                database.SaveChanges();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_employeeId == -1) AddEmployee();
            else UpdateEmployee();
            Close();
        }

        private void ValidateInputs()
        {
            var isUsernameValid = usernameInput.Text.Length > 0;
            var isFullNameValid = nameInput.Text.Length > 0;
            var isPasswordValid = passwordInput.Text.Length > 0;

            okButton.Enabled = isPasswordValid && isFullNameValid && isUsernameValid;
        }

        private void Inputs_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}