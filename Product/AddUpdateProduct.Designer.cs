namespace AromasEstoque
{
    partial class AddUpdateProduct
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
            this.descriptionHeader = new MetroFramework.Controls.MetroLabel();
            this.descriptionInput = new MetroFramework.Controls.MetroTextBox();
            this.barcodeHeader = new MetroFramework.Controls.MetroLabel();
            this.barcodeInput = new MetroFramework.Controls.MetroTextBox();
            this.priceHeader = new MetroFramework.Controls.MetroLabel();
            this.priceInput = new MetroFramework.Controls.MetroTextBox();
            this.inventoryHeader = new MetroFramework.Controls.MetroLabel();
            this.inventorySelector = new System.Windows.Forms.NumericUpDown();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.AutoSize = true;
            this.descriptionHeader.Location = new System.Drawing.Point(24, 60);
            this.descriptionHeader.Name = "descriptionHeader";
            this.descriptionHeader.Size = new System.Drawing.Size(65, 19);
            this.descriptionHeader.TabIndex = 0;
            this.descriptionHeader.Text = "Descrição";
            // 
            // descriptionInput
            // 
            // 
            // 
            // 
            this.descriptionInput.CustomButton.Image = null;
            this.descriptionInput.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.descriptionInput.CustomButton.Name = "";
            this.descriptionInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionInput.CustomButton.TabIndex = 1;
            this.descriptionInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionInput.CustomButton.UseSelectable = true;
            this.descriptionInput.CustomButton.Visible = false;
            this.descriptionInput.Lines = new string[0];
            this.descriptionInput.Location = new System.Drawing.Point(28, 82);
            this.descriptionInput.MaxLength = 150;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PromptText = "Insira aqui o nome ou a descrição do seu produto";
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.SelectionLength = 0;
            this.descriptionInput.SelectionStart = 0;
            this.descriptionInput.ShortcutsEnabled = true;
            this.descriptionInput.Size = new System.Drawing.Size(360, 23);
            this.descriptionInput.Style = MetroFramework.MetroColorStyle.Green;
            this.descriptionInput.TabIndex = 1;
            this.descriptionInput.UseSelectable = true;
            this.descriptionInput.UseStyleColors = true;
            this.descriptionInput.WaterMark = "Insira aqui o nome ou a descrição do seu produto";
            this.descriptionInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionInput.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // barcodeHeader
            // 
            this.barcodeHeader.AutoSize = true;
            this.barcodeHeader.Location = new System.Drawing.Point(24, 121);
            this.barcodeHeader.Name = "barcodeHeader";
            this.barcodeHeader.Size = new System.Drawing.Size(113, 19);
            this.barcodeHeader.TabIndex = 2;
            this.barcodeHeader.Text = "Código de barras";
            // 
            // barcodeInput
            // 
            // 
            // 
            // 
            this.barcodeInput.CustomButton.Image = null;
            this.barcodeInput.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.barcodeInput.CustomButton.Name = "";
            this.barcodeInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.barcodeInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.barcodeInput.CustomButton.TabIndex = 1;
            this.barcodeInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.barcodeInput.CustomButton.UseSelectable = true;
            this.barcodeInput.CustomButton.Visible = false;
            this.barcodeInput.Lines = new string[0];
            this.barcodeInput.Location = new System.Drawing.Point(28, 143);
            this.barcodeInput.MaxLength = 13;
            this.barcodeInput.Name = "barcodeInput";
            this.barcodeInput.PasswordChar = '\0';
            this.barcodeInput.PromptText = "Código de barras";
            this.barcodeInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.barcodeInput.SelectedText = "";
            this.barcodeInput.SelectionLength = 0;
            this.barcodeInput.SelectionStart = 0;
            this.barcodeInput.ShortcutsEnabled = true;
            this.barcodeInput.Size = new System.Drawing.Size(109, 23);
            this.barcodeInput.Style = MetroFramework.MetroColorStyle.Green;
            this.barcodeInput.TabIndex = 3;
            this.barcodeInput.UseSelectable = true;
            this.barcodeInput.UseStyleColors = true;
            this.barcodeInput.WaterMark = "Código de barras";
            this.barcodeInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.barcodeInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.barcodeInput.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // priceHeader
            // 
            this.priceHeader.AutoSize = true;
            this.priceHeader.Location = new System.Drawing.Point(165, 121);
            this.priceHeader.Name = "priceHeader";
            this.priceHeader.Size = new System.Drawing.Size(101, 19);
            this.priceHeader.TabIndex = 4;
            this.priceHeader.Text = "Preço de venda";
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
            this.priceInput.Location = new System.Drawing.Point(169, 143);
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
            this.priceInput.TabIndex = 5;
            this.priceInput.Text = "0,00";
            this.priceInput.UseSelectable = true;
            this.priceInput.UseStyleColors = true;
            this.priceInput.WaterMark = "Preço de venda";
            this.priceInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.priceInput.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.priceInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceInput_KeyDown);
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceInput_KeyPress);
            // 
            // inventoryHeader
            // 
            this.inventoryHeader.AutoSize = true;
            this.inventoryHeader.Location = new System.Drawing.Point(306, 121);
            this.inventoryHeader.Name = "inventoryHeader";
            this.inventoryHeader.Size = new System.Drawing.Size(55, 19);
            this.inventoryHeader.TabIndex = 6;
            this.inventoryHeader.Text = "Estoque";
            // 
            // inventorySelector
            // 
            this.inventorySelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventorySelector.Location = new System.Drawing.Point(310, 143);
            this.inventorySelector.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.inventorySelector.Name = "inventorySelector";
            this.inventorySelector.Size = new System.Drawing.Size(78, 23);
            this.inventorySelector.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(244, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Cadastrar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(319, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(143, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "R$";
            // 
            // AddUpdateProduct
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(423, 243);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.inventorySelector);
            this.Controls.Add(this.inventoryHeader);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceHeader);
            this.Controls.Add(this.barcodeInput);
            this.Controls.Add(this.barcodeHeader);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.descriptionHeader);
            this.Name = "AddUpdateProduct";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cadastrando produto";
            ((System.ComponentModel.ISupportInitialize)(this.inventorySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel descriptionHeader;
        private MetroFramework.Controls.MetroTextBox descriptionInput;
        private MetroFramework.Controls.MetroLabel barcodeHeader;
        private MetroFramework.Controls.MetroTextBox barcodeInput;
        private MetroFramework.Controls.MetroLabel priceHeader;
        private MetroFramework.Controls.MetroTextBox priceInput;
        private MetroFramework.Controls.MetroLabel inventoryHeader;
        private System.Windows.Forms.NumericUpDown inventorySelector;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}