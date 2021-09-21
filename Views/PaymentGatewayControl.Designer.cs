namespace AromasEstoque
{
    partial class PaymentGatewayControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentGatewayControl));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.parcelSelector = new MetroFramework.Controls.MetroComboBox();
            this.debitPicture = new System.Windows.Forms.PictureBox();
            this.moneyPicture = new System.Windows.Forms.PictureBox();
            this.creditPicture = new System.Windows.Forms.PictureBox();
            this.creditInput = new MetroFramework.Controls.MetroTextBox();
            this.returnAmountDisplay = new MetroFramework.Controls.MetroLabel();
            this.moneyHeader = new MetroFramework.Controls.MetroLabel();
            this.moneyInput = new MetroFramework.Controls.MetroTextBox();
            this.debitInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.moneySelector = new MetroFramework.Controls.MetroCheckBox();
            this.debitSelector = new MetroFramework.Controls.MetroCheckBox();
            this.creditSelector = new MetroFramework.Controls.MetroCheckBox();
            this.payButton = new MetroFramework.Controls.MetroButton();
            this.amountToPayDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(487, 181);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "R$";
            // 
            // parcelSelector
            // 
            this.parcelSelector.Enabled = false;
            this.parcelSelector.FormattingEnabled = true;
            this.parcelSelector.ItemHeight = 23;
            this.parcelSelector.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.parcelSelector.Location = new System.Drawing.Point(620, 148);
            this.parcelSelector.Name = "parcelSelector";
            this.parcelSelector.Size = new System.Drawing.Size(65, 29);
            this.parcelSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.parcelSelector.TabIndex = 13;
            this.parcelSelector.UseSelectable = true;
            this.parcelSelector.UseStyleColors = true;
            // 
            // debitPicture
            // 
            this.debitPicture.Image = ((System.Drawing.Image)(resources.GetObject("debitPicture.Image")));
            this.debitPicture.Location = new System.Drawing.Point(321, 83);
            this.debitPicture.Name = "debitPicture";
            this.debitPicture.Size = new System.Drawing.Size(64, 64);
            this.debitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.debitPicture.TabIndex = 15;
            this.debitPicture.TabStop = false;
            // 
            // moneyPicture
            // 
            this.moneyPicture.Image = ((System.Drawing.Image)(resources.GetObject("moneyPicture.Image")));
            this.moneyPicture.Location = new System.Drawing.Point(132, 83);
            this.moneyPicture.Name = "moneyPicture";
            this.moneyPicture.Size = new System.Drawing.Size(64, 64);
            this.moneyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.moneyPicture.TabIndex = 16;
            this.moneyPicture.TabStop = false;
            // 
            // creditPicture
            // 
            this.creditPicture.Image = ((System.Drawing.Image)(resources.GetObject("creditPicture.Image")));
            this.creditPicture.Location = new System.Drawing.Point(515, 83);
            this.creditPicture.Name = "creditPicture";
            this.creditPicture.Size = new System.Drawing.Size(64, 64);
            this.creditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creditPicture.TabIndex = 17;
            this.creditPicture.TabStop = false;
            // 
            // creditInput
            // 
            // 
            // 
            // 
            this.creditInput.CustomButton.Image = null;
            this.creditInput.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.creditInput.CustomButton.Name = "";
            this.creditInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.creditInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.creditInput.CustomButton.TabIndex = 1;
            this.creditInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.creditInput.CustomButton.UseSelectable = true;
            this.creditInput.CustomButton.Visible = false;
            this.creditInput.Enabled = false;
            this.creditInput.Lines = new string[] {
        "0,00"};
            this.creditInput.Location = new System.Drawing.Point(515, 180);
            this.creditInput.MaxLength = 32767;
            this.creditInput.Name = "creditInput";
            this.creditInput.PasswordChar = '\0';
            this.creditInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.creditInput.SelectedText = "";
            this.creditInput.SelectionLength = 0;
            this.creditInput.SelectionStart = 0;
            this.creditInput.ShortcutsEnabled = true;
            this.creditInput.Size = new System.Drawing.Size(76, 23);
            this.creditInput.Style = MetroFramework.MetroColorStyle.Green;
            this.creditInput.TabIndex = 18;
            this.creditInput.Text = "0,00";
            this.creditInput.UseSelectable = true;
            this.creditInput.UseStyleColors = true;
            this.creditInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.creditInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.creditInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidInput_KeyDown);
            this.creditInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaidInput_KeyPress);
            // 
            // returnAmountDisplay
            // 
            this.returnAmountDisplay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.returnAmountDisplay.Location = new System.Drawing.Point(0, 225);
            this.returnAmountDisplay.Name = "returnAmountDisplay";
            this.returnAmountDisplay.Size = new System.Drawing.Size(722, 34);
            this.returnAmountDisplay.TabIndex = 20;
            this.returnAmountDisplay.Text = "Troco: R$ 0,00";
            this.returnAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyHeader
            // 
            this.moneyHeader.AutoSize = true;
            this.moneyHeader.Location = new System.Drawing.Point(113, 181);
            this.moneyHeader.Name = "moneyHeader";
            this.moneyHeader.Size = new System.Drawing.Size(24, 19);
            this.moneyHeader.TabIndex = 21;
            this.moneyHeader.Text = "R$";
            // 
            // moneyInput
            // 
            // 
            // 
            // 
            this.moneyInput.CustomButton.Image = null;
            this.moneyInput.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.moneyInput.CustomButton.Name = "";
            this.moneyInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.moneyInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.moneyInput.CustomButton.TabIndex = 1;
            this.moneyInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.moneyInput.CustomButton.UseSelectable = true;
            this.moneyInput.CustomButton.Visible = false;
            this.moneyInput.Lines = new string[] {
        "0,00"};
            this.moneyInput.Location = new System.Drawing.Point(143, 180);
            this.moneyInput.MaxLength = 32767;
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.PasswordChar = '\0';
            this.moneyInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.moneyInput.SelectedText = "";
            this.moneyInput.SelectionLength = 0;
            this.moneyInput.SelectionStart = 0;
            this.moneyInput.ShortcutsEnabled = true;
            this.moneyInput.Size = new System.Drawing.Size(76, 23);
            this.moneyInput.Style = MetroFramework.MetroColorStyle.Green;
            this.moneyInput.TabIndex = 22;
            this.moneyInput.Text = "0,00";
            this.moneyInput.UseSelectable = true;
            this.moneyInput.UseStyleColors = true;
            this.moneyInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.moneyInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.moneyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidInput_KeyDown);
            this.moneyInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaidInput_KeyPress);
            // 
            // debitInput
            // 
            // 
            // 
            // 
            this.debitInput.CustomButton.Image = null;
            this.debitInput.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.debitInput.CustomButton.Name = "";
            this.debitInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.debitInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.debitInput.CustomButton.TabIndex = 1;
            this.debitInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.debitInput.CustomButton.UseSelectable = true;
            this.debitInput.CustomButton.Visible = false;
            this.debitInput.Enabled = false;
            this.debitInput.Lines = new string[] {
        "0,00"};
            this.debitInput.Location = new System.Drawing.Point(329, 180);
            this.debitInput.MaxLength = 32767;
            this.debitInput.Name = "debitInput";
            this.debitInput.PasswordChar = '\0';
            this.debitInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.debitInput.SelectedText = "";
            this.debitInput.SelectionLength = 0;
            this.debitInput.SelectionStart = 0;
            this.debitInput.ShortcutsEnabled = true;
            this.debitInput.Size = new System.Drawing.Size(76, 23);
            this.debitInput.Style = MetroFramework.MetroColorStyle.Green;
            this.debitInput.TabIndex = 23;
            this.debitInput.Text = "0,00";
            this.debitInput.UseSelectable = true;
            this.debitInput.UseStyleColors = true;
            this.debitInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.debitInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.debitInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidInput_KeyDown);
            this.debitInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaidInput_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(299, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "R$";
            // 
            // moneySelector
            // 
            this.moneySelector.AutoSize = true;
            this.moneySelector.Checked = true;
            this.moneySelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moneySelector.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.moneySelector.Location = new System.Drawing.Point(129, 156);
            this.moneySelector.Name = "moneySelector";
            this.moneySelector.Size = new System.Drawing.Size(77, 19);
            this.moneySelector.Style = MetroFramework.MetroColorStyle.Green;
            this.moneySelector.TabIndex = 25;
            this.moneySelector.Text = "Dinheiro";
            this.moneySelector.UseSelectable = true;
            this.moneySelector.CheckedChanged += new System.EventHandler(this.MethodCheck_CheckedChanged);
            // 
            // debitSelector
            // 
            this.debitSelector.AutoSize = true;
            this.debitSelector.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.debitSelector.Location = new System.Drawing.Point(321, 155);
            this.debitSelector.Name = "debitSelector";
            this.debitSelector.Size = new System.Drawing.Size(66, 19);
            this.debitSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.debitSelector.TabIndex = 26;
            this.debitSelector.Text = "Débito";
            this.debitSelector.UseSelectable = true;
            this.debitSelector.CheckedChanged += new System.EventHandler(this.MethodCheck_CheckedChanged);
            // 
            // creditSelector
            // 
            this.creditSelector.AutoSize = true;
            this.creditSelector.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.creditSelector.Location = new System.Drawing.Point(478, 153);
            this.creditSelector.Name = "creditSelector";
            this.creditSelector.Size = new System.Drawing.Size(134, 19);
            this.creditSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.creditSelector.TabIndex = 27;
            this.creditSelector.Text = "Cartão de Crédito";
            this.creditSelector.UseSelectable = true;
            this.creditSelector.CheckedChanged += new System.EventHandler(this.MethodCheck_CheckedChanged);
            // 
            // payButton
            // 
            this.payButton.Highlight = true;
            this.payButton.Location = new System.Drawing.Point(267, 281);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(191, 35);
            this.payButton.Style = MetroFramework.MetroColorStyle.Green;
            this.payButton.TabIndex = 28;
            this.payButton.Text = "Efetuar pagamento";
            this.payButton.UseSelectable = true;
            this.payButton.UseStyleColors = true;
            this.payButton.Visible = false;
            this.payButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // amountToPayDisplay
            // 
            this.amountToPayDisplay.BackColor = System.Drawing.Color.White;
            this.amountToPayDisplay.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.amountToPayDisplay.Location = new System.Drawing.Point(0, 18);
            this.amountToPayDisplay.Name = "amountToPayDisplay";
            this.amountToPayDisplay.Size = new System.Drawing.Size(725, 37);
            this.amountToPayDisplay.TabIndex = 29;
            this.amountToPayDisplay.Text = "Total a pagar: R$ 0,00";
            this.amountToPayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentGatewayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.amountToPayDisplay);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.creditSelector);
            this.Controls.Add(this.debitSelector);
            this.Controls.Add(this.moneySelector);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.debitInput);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.moneyHeader);
            this.Controls.Add(this.returnAmountDisplay);
            this.Controls.Add(this.creditInput);
            this.Controls.Add(this.creditPicture);
            this.Controls.Add(this.moneyPicture);
            this.Controls.Add(this.debitPicture);
            this.Controls.Add(this.parcelSelector);
            this.Controls.Add(this.metroLabel2);
            this.Name = "PaymentGatewayControl";
            this.Size = new System.Drawing.Size(725, 338);
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox creditInput;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox parcelSelector;
        private System.Windows.Forms.PictureBox debitPicture;
        private System.Windows.Forms.PictureBox moneyPicture;
        private System.Windows.Forms.PictureBox creditPicture;
        private MetroFramework.Controls.MetroLabel returnAmountDisplay;
        private MetroFramework.Controls.MetroLabel moneyHeader;
        private MetroFramework.Controls.MetroTextBox moneyInput;
        private MetroFramework.Controls.MetroTextBox debitInput;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox moneySelector;
        private MetroFramework.Controls.MetroCheckBox debitSelector;
        private MetroFramework.Controls.MetroCheckBox creditSelector;
        private MetroFramework.Controls.MetroButton payButton;
        private System.Windows.Forms.Label amountToPayDisplay;
    }
}
