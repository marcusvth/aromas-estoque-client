using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class CashierOperations : MetroForm
    {
        public CashierOperations()
        {
            InitializeComponent();
        }

        private void AmountInput_KeyDown(object sender, KeyEventArgs e)
        {
            amountInput.Monify(e);
        }

        private void AmountInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!readjustOption.Checked)
                Transact();
            else
                Readjust();
            Close();
        }

        private void Readjust()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.VaultBalance.Add(new VaultBalance
                {
                    ReferenceDate = DateTime.Now,
                    AdjustmentType = "M",
                    Balance = decimal.Parse(amountInput.Text),
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId
                });
                database.SaveChanges();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Transact()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Transactions.Add(new Transactions
                {
                    EventDate = DateTime.Now,
                    Amount = decimal.Parse(amountInput.Text),
                    Category = depositOption.Checked ? "D" : "W",
                    Comment = commentInput.Text,
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                    Currency = "M"
                });

                database.SaveChanges();
            }
        }

        private void ReadjustOption_CheckedChanged(object sender, EventArgs e)
        {
            commentInput.Visible = !readjustOption.Checked;
        }

        private void AmountInput_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = decimal.Parse(amountInput.Text) > 0;
        }
    }
}