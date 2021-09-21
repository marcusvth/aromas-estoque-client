using System;
using System.Windows.Forms;
using AromasEstoque.Controllers;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class CashierOperations : MetroForm, ICasherOperations
    {
        public decimal Amount => decimal.Parse(amountInput.Text);
        public string Comment => commentInput.Text;
        public bool IsReadjustment => readjustOption.Checked;
        public bool IsDeposit => depositOption.Checked;
        private CashierOperationsController _controller;
        public CashierOperations()
        {
            InitializeComponent();
            _controller = new CashierOperationsController(this);
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
            _controller.CompleteOperation();
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ReadjustOption_CheckedChanged(object sender, EventArgs e)
        {
            commentInput.Visible = !readjustOption.Checked;
        }

        private void AmountInput_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = decimal.Parse(amountInput.Text) > 0 && MainDashboard.IsActionAllowed;
        }
    }
}