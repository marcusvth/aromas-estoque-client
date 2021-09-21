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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtPayment));
            this.paymentMethodPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paymentMethodPanel
            // 
            this.paymentMethodPanel.BackColor = System.Drawing.Color.White;
            this.paymentMethodPanel.Location = new System.Drawing.Point(138, 101);
            this.paymentMethodPanel.Name = "paymentMethodPanel";
            this.paymentMethodPanel.Size = new System.Drawing.Size(725, 338);
            this.paymentMethodPanel.TabIndex = 3;
            // 
            // DebtPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 518);
            this.Controls.Add(this.paymentMethodPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DebtPayment";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pagamento de venda nº 0";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel paymentMethodPanel;
    }
}