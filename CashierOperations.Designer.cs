namespace AromasEstoque
{
    partial class CashierOperations
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
            this.amountInput = new MetroFramework.Controls.MetroTextBox();
            this.currencySymbol = new MetroFramework.Controls.MetroLabel();
            this.amountHeader = new MetroFramework.Controls.MetroLabel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.depositOption = new MetroFramework.Controls.MetroRadioButton();
            this.pickUpOption = new MetroFramework.Controls.MetroRadioButton();
            this.commentInput = new MetroFramework.Controls.MetroTextBox();
            this.readjustOption = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // amountInput
            // 
            // 
            // 
            // 
            this.amountInput.CustomButton.Image = null;
            this.amountInput.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.amountInput.CustomButton.Name = "";
            this.amountInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountInput.CustomButton.TabIndex = 1;
            this.amountInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountInput.CustomButton.UseSelectable = true;
            this.amountInput.CustomButton.Visible = false;
            this.amountInput.Lines = new string[] {
        "0,00"};
            this.amountInput.Location = new System.Drawing.Point(256, 99);
            this.amountInput.MaxLength = 32767;
            this.amountInput.Name = "amountInput";
            this.amountInput.PasswordChar = '\0';
            this.amountInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountInput.SelectedText = "";
            this.amountInput.SelectionLength = 0;
            this.amountInput.SelectionStart = 0;
            this.amountInput.ShortcutsEnabled = true;
            this.amountInput.Size = new System.Drawing.Size(113, 23);
            this.amountInput.Style = MetroFramework.MetroColorStyle.Green;
            this.amountInput.TabIndex = 0;
            this.amountInput.Text = "0,00";
            this.amountInput.UseSelectable = true;
            this.amountInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.amountInput.TextChanged += new System.EventHandler(this.AmountInput_TextChanged);
            this.amountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmountInput_KeyDown);
            this.amountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountInput_KeyPress);
            // 
            // currencySymbol
            // 
            this.currencySymbol.AutoSize = true;
            this.currencySymbol.Location = new System.Drawing.Point(230, 101);
            this.currencySymbol.Name = "currencySymbol";
            this.currencySymbol.Size = new System.Drawing.Size(24, 19);
            this.currencySymbol.TabIndex = 12;
            this.currencySymbol.Text = "R$";
            // 
            // amountHeader
            // 
            this.amountHeader.AutoSize = true;
            this.amountHeader.Location = new System.Drawing.Point(145, 71);
            this.amountHeader.Name = "amountHeader";
            this.amountHeader.Size = new System.Drawing.Size(308, 19);
            this.amountHeader.TabIndex = 15;
            this.amountHeader.Text = "Digite a quantia para depósito, retirada ou reajuste";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(504, 241);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(429, 241);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 16;
            this.okButton.Text = "Confirmar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // depositOption
            // 
            this.depositOption.AutoSize = true;
            this.depositOption.Checked = true;
            this.depositOption.Location = new System.Drawing.Point(174, 135);
            this.depositOption.Name = "depositOption";
            this.depositOption.Size = new System.Drawing.Size(110, 15);
            this.depositOption.Style = MetroFramework.MetroColorStyle.Green;
            this.depositOption.TabIndex = 18;
            this.depositOption.TabStop = true;
            this.depositOption.Text = "Reforço de caixa";
            this.depositOption.UseSelectable = true;
            // 
            // pickUpOption
            // 
            this.pickUpOption.AutoSize = true;
            this.pickUpOption.Location = new System.Drawing.Point(290, 135);
            this.pickUpOption.Name = "pickUpOption";
            this.pickUpOption.Size = new System.Drawing.Size(62, 15);
            this.pickUpOption.Style = MetroFramework.MetroColorStyle.Green;
            this.pickUpOption.TabIndex = 19;
            this.pickUpOption.Text = "Sangria";
            this.pickUpOption.UseSelectable = true;
            // 
            // commentInput
            // 
            // 
            // 
            // 
            this.commentInput.CustomButton.Image = null;
            this.commentInput.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.commentInput.CustomButton.Name = "";
            this.commentInput.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.commentInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.commentInput.CustomButton.TabIndex = 1;
            this.commentInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.commentInput.CustomButton.UseSelectable = true;
            this.commentInput.CustomButton.Visible = false;
            this.commentInput.Lines = new string[0];
            this.commentInput.Location = new System.Drawing.Point(171, 161);
            this.commentInput.MaxLength = 255;
            this.commentInput.Multiline = true;
            this.commentInput.Name = "commentInput";
            this.commentInput.PasswordChar = '\0';
            this.commentInput.PromptText = "Insira um comentário para a operação";
            this.commentInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commentInput.SelectedText = "";
            this.commentInput.SelectionLength = 0;
            this.commentInput.SelectionStart = 0;
            this.commentInput.ShortcutsEnabled = true;
            this.commentInput.Size = new System.Drawing.Size(256, 55);
            this.commentInput.Style = MetroFramework.MetroColorStyle.Green;
            this.commentInput.TabIndex = 21;
            this.commentInput.UseSelectable = true;
            this.commentInput.WaterMark = "Insira um comentário para a operação";
            this.commentInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.commentInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // readjustOption
            // 
            this.readjustOption.AutoSize = true;
            this.readjustOption.Location = new System.Drawing.Point(358, 135);
            this.readjustOption.Name = "readjustOption";
            this.readjustOption.Size = new System.Drawing.Size(67, 15);
            this.readjustOption.Style = MetroFramework.MetroColorStyle.Green;
            this.readjustOption.TabIndex = 22;
            this.readjustOption.Text = "Reajuste";
            this.readjustOption.UseSelectable = true;
            this.readjustOption.CheckedChanged += new System.EventHandler(this.ReadjustOption_CheckedChanged);
            // 
            // CashierOperations
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(598, 293);
            this.Controls.Add(this.readjustOption);
            this.Controls.Add(this.commentInput);
            this.Controls.Add(this.pickUpOption);
            this.Controls.Add(this.depositOption);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.amountHeader);
            this.Controls.Add(this.currencySymbol);
            this.Controls.Add(this.amountInput);
            this.MaximizeBox = false;
            this.Name = "CashierOperations";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Operações de caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox amountInput;
        private MetroFramework.Controls.MetroLabel currencySymbol;
        private MetroFramework.Controls.MetroLabel amountHeader;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroRadioButton depositOption;
        private MetroFramework.Controls.MetroRadioButton pickUpOption;
        private MetroFramework.Controls.MetroTextBox commentInput;
        private MetroFramework.Controls.MetroRadioButton readjustOption;
    }
}