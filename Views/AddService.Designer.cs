namespace AromasEstoque
{
    partial class AddService
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
            this.customerPanel = new System.Windows.Forms.Panel();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.descriptionInput = new MetroFramework.Controls.MetroTextBox();
            this.nameHeader = new MetroFramework.Controls.MetroLabel();
            this.priceHeader = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.priceInput = new MetroFramework.Controls.MetroTextBox();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.providerSelector = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // customerPanel
            // 
            this.customerPanel.Location = new System.Drawing.Point(71, 467);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(715, 105);
            this.customerPanel.TabIndex = 5;
            // 
            // paymentPanel
            // 
            this.paymentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentPanel.BackColor = System.Drawing.Color.White;
            this.paymentPanel.Location = new System.Drawing.Point(66, 124);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(725, 338);
            this.paymentPanel.TabIndex = 4;
            // 
            // descriptionInput
            // 
            // 
            // 
            // 
            this.descriptionInput.CustomButton.Image = null;
            this.descriptionInput.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.descriptionInput.CustomButton.Name = "";
            this.descriptionInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionInput.CustomButton.TabIndex = 1;
            this.descriptionInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionInput.CustomButton.UseSelectable = true;
            this.descriptionInput.CustomButton.Visible = false;
            this.descriptionInput.Lines = new string[0];
            this.descriptionInput.Location = new System.Drawing.Point(65, 93);
            this.descriptionInput.MaxLength = 150;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PromptText = "Insira a descrição do serviço";
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.SelectionLength = 0;
            this.descriptionInput.SelectionStart = 0;
            this.descriptionInput.ShortcutsEnabled = true;
            this.descriptionInput.Size = new System.Drawing.Size(238, 23);
            this.descriptionInput.Style = MetroFramework.MetroColorStyle.Green;
            this.descriptionInput.TabIndex = 13;
            this.descriptionInput.UseSelectable = true;
            this.descriptionInput.UseStyleColors = true;
            this.descriptionInput.WaterMark = "Insira a descrição do serviço";
            this.descriptionInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionInput.TextChanged += new System.EventHandler(this.DescriptionInput_TextChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Location = new System.Drawing.Point(65, 64);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(65, 19);
            this.nameHeader.TabIndex = 12;
            this.nameHeader.Text = "Descrição";
            // 
            // priceHeader
            // 
            this.priceHeader.AutoSize = true;
            this.priceHeader.Location = new System.Drawing.Point(322, 64);
            this.priceHeader.Name = "priceHeader";
            this.priceHeader.Size = new System.Drawing.Size(38, 19);
            this.priceHeader.TabIndex = 14;
            this.priceHeader.Text = "Valor";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(326, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "R$";
            // 
            // priceInput
            // 
            // 
            // 
            // 
            this.priceInput.CustomButton.Image = null;
            this.priceInput.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.priceInput.CustomButton.Name = "";
            this.priceInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceInput.CustomButton.TabIndex = 1;
            this.priceInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceInput.CustomButton.UseSelectable = true;
            this.priceInput.CustomButton.Visible = false;
            this.priceInput.Lines = new string[] {
        "0,00"};
            this.priceInput.Location = new System.Drawing.Point(352, 93);
            this.priceInput.MaxLength = 150;
            this.priceInput.Name = "priceInput";
            this.priceInput.PasswordChar = '\0';
            this.priceInput.PromptText = "Preço de venda";
            this.priceInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceInput.SelectedText = "";
            this.priceInput.SelectionLength = 0;
            this.priceInput.SelectionStart = 0;
            this.priceInput.ShortcutsEnabled = true;
            this.priceInput.Size = new System.Drawing.Size(109, 23);
            this.priceInput.Style = MetroFramework.MetroColorStyle.Green;
            this.priceInput.TabIndex = 22;
            this.priceInput.Text = "0,00";
            this.priceInput.UseSelectable = true;
            this.priceInput.UseStyleColors = true;
            this.priceInput.WaterMark = "Preço de venda";
            this.priceInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.priceInput.TextChanged += new System.EventHandler(this.PriceInput_TextChanged);
            this.priceInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceInput_KeyDown);
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(764, 585);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(689, 585);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 24;
            this.okButton.Text = "Confirmar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(504, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Prestador de serviço";
            // 
            // providerSelector
            // 
            this.providerSelector.FormattingEnabled = true;
            this.providerSelector.ItemHeight = 23;
            this.providerSelector.Location = new System.Drawing.Point(504, 87);
            this.providerSelector.Name = "providerSelector";
            this.providerSelector.Size = new System.Drawing.Size(285, 29);
            this.providerSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.providerSelector.TabIndex = 27;
            this.providerSelector.UseSelectable = true;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 630);
            this.Controls.Add(this.providerSelector);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceHeader);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.nameHeader);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.paymentPanel);
            this.MaximizeBox = false;
            this.Name = "AddService";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Novo serviço";
            this.Shown += new System.EventHandler(this.AddService_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Panel paymentPanel;
        private MetroFramework.Controls.MetroTextBox descriptionInput;
        private MetroFramework.Controls.MetroLabel nameHeader;
        private MetroFramework.Controls.MetroLabel priceHeader;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox priceInput;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox providerSelector;
    }
}