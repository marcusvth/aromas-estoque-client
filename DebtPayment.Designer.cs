namespace AromasEstoque
{
    partial class DebtPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paymentMethodPanel = new System.Windows.Forms.Panel();
            this.payDebtButton = new MetroFramework.Controls.MetroButton();
            this.pendingAmountDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentMethodPanel
            // 
            this.paymentMethodPanel.BackColor = System.Drawing.Color.White;
            this.paymentMethodPanel.Location = new System.Drawing.Point(138, 130);
            this.paymentMethodPanel.Name = "paymentMethodPanel";
            this.paymentMethodPanel.Size = new System.Drawing.Size(725, 190);
            this.paymentMethodPanel.TabIndex = 3;
            // 
            // payDebtButton
            // 
            this.payDebtButton.Enabled = false;
            this.payDebtButton.Highlight = true;
            this.payDebtButton.Location = new System.Drawing.Point(405, 330);
            this.payDebtButton.Name = "payDebtButton";
            this.payDebtButton.Size = new System.Drawing.Size(191, 35);
            this.payDebtButton.Style = MetroFramework.MetroColorStyle.Green;
            this.payDebtButton.TabIndex = 12;
            this.payDebtButton.Text = "Efetuar pagamento";
            this.payDebtButton.UseSelectable = true;
            this.payDebtButton.UseStyleColors = true;
            this.payDebtButton.Click += new System.EventHandler(this.PayDebtButton_Click);
            // 
            // pendingAmountDisplay
            // 
            this.pendingAmountDisplay.BackColor = System.Drawing.Color.White;
            this.pendingAmountDisplay.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.pendingAmountDisplay.Location = new System.Drawing.Point(2, 78);
            this.pendingAmountDisplay.Name = "pendingAmountDisplay";
            this.pendingAmountDisplay.Size = new System.Drawing.Size(999, 37);
            this.pendingAmountDisplay.TabIndex = 13;
            this.pendingAmountDisplay.Text = "R$ 0,00 restantes de R$ 139,00";
            this.pendingAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DebtPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 390);
            this.Controls.Add(this.pendingAmountDisplay);
            this.Controls.Add(this.payDebtButton);
            this.Controls.Add(this.paymentMethodPanel);
            this.MaximizeBox = false;
            this.Name = "DebtPayment";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pagamento de venda nº 0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paymentMethodPanel;
        private MetroFramework.Controls.MetroButton payDebtButton;
        private System.Windows.Forms.Label pendingAmountDisplay;
    }
}