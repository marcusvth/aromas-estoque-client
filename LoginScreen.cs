using System;
using System.Linq;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class LoginScreen : MetroForm
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private bool ValidateCredentials()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var employee = database.Employee.FirstOrDefault(e => e.Username == usernameInput.Text);
                MainDashboard.CurrentEmployee = employee;
                return !(employee is null) && employee.PasswordHash.Equals(passwordInput.Text);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidateCredentials())
            {
                Hide();
                new MainDashboard().ShowDialog();
            }
            else
            {
                ShowBadPwd();
            }
        }

        private void ShowBadPwd()
        {
            badPwdMessage.Visible = true;
            usernameInput.WithError = true;
            passwordInput.WithError = true;
        }

        private void LoginScreen_Shown(object sender, EventArgs e)
        {
            Activate();
        }
    }
}