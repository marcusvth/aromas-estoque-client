namespace AromasEstoque
{
    partial class PaymentMethodSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodSelector));
            this.moneySelector = new MetroFramework.Controls.MetroRadioButton();
            this.creditSelector = new MetroFramework.Controls.MetroRadioButton();
            this.debitSelector = new MetroFramework.Controls.MetroRadioButton();
            this.customerSelector = new MetroFramework.Controls.MetroComboBox();
            this.customerHeader = new MetroFramework.Controls.MetroLabel();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.notIdenfityCustomerCheck = new MetroFramework.Controls.MetroCheckBox();
            this.parcelSelector = new MetroFramework.Controls.MetroComboBox();
            this.debitPicture = new System.Windows.Forms.PictureBox();
            this.moneyPicture = new System.Windows.Forms.PictureBox();
            this.creditPicture = new System.Windows.Forms.PictureBox();
            this.paidAmountInput = new MetroFramework.Controls.MetroTextBox();
            this.customerOnlyPanel = new System.Windows.Forms.Panel();
            this.returnAmountDisplay = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).BeginInit();
            this.customerOnlyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneySelector
            // 
            this.moneySelector.AutoSize = true;
            this.moneySelector.Checked = true;
            this.moneySelector.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.moneySelector.Location = new System.Drawing.Point(109, 76);
            this.moneySelector.Name = "moneySelector";
            this.moneySelector.Size = new System.Drawing.Size(95, 25);
            this.moneySelector.Style = MetroFramework.MetroColorStyle.Green;
            this.moneySelector.TabIndex = 0;
            this.moneySelector.TabStop = true;
            this.moneySelector.Text = "Dinheiro";
            this.moneySelector.UseSelectable = true;
            this.moneySelector.CheckedChanged += new System.EventHandler(this.PaymentSelector_CheckedChanged);
            // 
            // creditSelector
            // 
            this.creditSelector.AutoSize = true;
            this.creditSelector.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.creditSelector.Location = new System.Drawing.Point(456, 76);
            this.creditSelector.Name = "creditSelector";
            this.creditSelector.Size = new System.Drawing.Size(165, 25);
            this.creditSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.creditSelector.TabIndex = 1;
            this.creditSelector.Text = "Cartão de crédito";
            this.creditSelector.UseSelectable = true;
            this.creditSelector.CheckedChanged += new System.EventHandler(this.PaymentSelector_CheckedChanged);
            // 
            // debitSelector
            // 
            this.debitSelector.AutoSize = true;
            this.debitSelector.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.debitSelector.Location = new System.Drawing.Point(289, 76);
            this.debitSelector.Name = "debitSelector";
            this.debitSelector.Size = new System.Drawing.Size(82, 25);
            this.debitSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.debitSelector.TabIndex = 2;
            this.debitSelector.Text = "Débito";
            this.debitSelector.UseSelectable = true;
            this.debitSelector.CheckedChanged += new System.EventHandler(this.PaymentSelector_CheckedChanged);
            // 
            // customerSelector
            // 
            this.customerSelector.FormattingEnabled = true;
            this.customerSelector.ItemHeight = 23;
            this.customerSelector.Location = new System.Drawing.Point(42, 34);
            this.customerSelector.Name = "customerSelector";
            this.customerSelector.Size = new System.Drawing.Size(485, 29);
            this.customerSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.customerSelector.TabIndex = 5;
            this.customerSelector.UseSelectable = true;
            // 
            // customerHeader
            // 
            this.customerHeader.AutoSize = true;
            this.customerHeader.Location = new System.Drawing.Point(239, 9);
            this.customerHeader.Name = "customerHeader";
            this.customerHeader.Size = new System.Drawing.Size(172, 19);
            this.customerHeader.TabIndex = 6;
            this.customerHeader.Text = "Selecione um cliente na lista";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(533, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 29);
            this.addButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Cadastrar cliente";
            this.addButton.UseSelectable = true;
            this.addButton.UseStyleColors = true;
            this.addButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(260, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "R$";
            // 
            // notIdenfityCustomerCheck
            // 
            this.notIdenfityCustomerCheck.AutoSize = true;
            this.notIdenfityCustomerCheck.Location = new System.Drawing.Point(256, 79);
            this.notIdenfityCustomerCheck.Name = "notIdenfityCustomerCheck";
            this.notIdenfityCustomerCheck.Size = new System.Drawing.Size(139, 15);
            this.notIdenfityCustomerCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.notIdenfityCustomerCheck.TabIndex = 12;
            this.notIdenfityCustomerCheck.Text = "Não identificar cliente";
            this.notIdenfityCustomerCheck.UseSelectable = true;
            this.notIdenfityCustomerCheck.CheckedChanged += new System.EventHandler(this.UndefinedCustomer_CheckedChanged);
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
            this.parcelSelector.Location = new System.Drawing.Point(509, 107);
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
            this.debitPicture.Location = new System.Drawing.Point(304, 6);
            this.debitPicture.Name = "debitPicture";
            this.debitPicture.Size = new System.Drawing.Size(64, 64);
            this.debitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.debitPicture.TabIndex = 15;
            this.debitPicture.TabStop = false;
            // 
            // moneyPicture
            // 
            this.moneyPicture.Image = ((System.Drawing.Image)(resources.GetObject("moneyPicture.Image")));
            this.moneyPicture.Location = new System.Drawing.Point(126, 6);
            this.moneyPicture.Name = "moneyPicture";
            this.moneyPicture.Size = new System.Drawing.Size(64, 64);
            this.moneyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.moneyPicture.TabIndex = 16;
            this.moneyPicture.TabStop = false;
            // 
            // creditPicture
            // 
            this.creditPicture.Image = ((System.Drawing.Image)(resources.GetObject("creditPicture.Image")));
            this.creditPicture.Location = new System.Drawing.Point(509, 6);
            this.creditPicture.Name = "creditPicture";
            this.creditPicture.Size = new System.Drawing.Size(64, 64);
            this.creditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creditPicture.TabIndex = 17;
            this.creditPicture.TabStop = false;
            // 
            // paidAmountInput
            // 
            // 
            // 
            // 
            this.paidAmountInput.CustomButton.Image = null;
            this.paidAmountInput.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.paidAmountInput.CustomButton.Name = "";
            this.paidAmountInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.paidAmountInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.paidAmountInput.CustomButton.TabIndex = 1;
            this.paidAmountInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paidAmountInput.CustomButton.UseSelectable = true;
            this.paidAmountInput.CustomButton.Visible = false;
            this.paidAmountInput.Lines = new string[] {
        "0,00"};
            this.paidAmountInput.Location = new System.Drawing.Point(289, 140);
            this.paidAmountInput.MaxLength = 32767;
            this.paidAmountInput.Name = "paidAmountInput";
            this.paidAmountInput.PasswordChar = '\0';
            this.paidAmountInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paidAmountInput.SelectedText = "";
            this.paidAmountInput.SelectionLength = 0;
            this.paidAmountInput.SelectionStart = 0;
            this.paidAmountInput.ShortcutsEnabled = true;
            this.paidAmountInput.Size = new System.Drawing.Size(146, 23);
            this.paidAmountInput.Style = MetroFramework.MetroColorStyle.Green;
            this.paidAmountInput.TabIndex = 18;
            this.paidAmountInput.Text = "0,00";
            this.paidAmountInput.UseSelectable = true;
            this.paidAmountInput.UseStyleColors = true;
            this.paidAmountInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.paidAmountInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.paidAmountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidInput_KeyDown);
            this.paidAmountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaidInput_KeyPress);
            // 
            // customerOnlyPanel
            // 
            this.customerOnlyPanel.Controls.Add(this.notIdenfityCustomerCheck);
            this.customerOnlyPanel.Controls.Add(this.addButton);
            this.customerOnlyPanel.Controls.Add(this.customerHeader);
            this.customerOnlyPanel.Controls.Add(this.customerSelector);
            this.customerOnlyPanel.Enabled = false;
            this.customerOnlyPanel.Location = new System.Drawing.Point(21, 191);
            this.customerOnlyPanel.Name = "customerOnlyPanel";
            this.customerOnlyPanel.Size = new System.Drawing.Size(682, 106);
            this.customerOnlyPanel.TabIndex = 19;
            // 
            // returnAmountDisplay
            // 
            this.returnAmountDisplay.Location = new System.Drawing.Point(0, 167);
            this.returnAmountDisplay.Name = "returnAmountDisplay";
            this.returnAmountDisplay.Size = new System.Drawing.Size(722, 19);
            this.returnAmountDisplay.TabIndex = 20;
            this.returnAmountDisplay.Text = "Troco: R$ 0,00";
            this.returnAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentMethodSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.returnAmountDisplay);
            this.Controls.Add(this.customerOnlyPanel);
            this.Controls.Add(this.paidAmountInput);
            this.Controls.Add(this.creditPicture);
            this.Controls.Add(this.moneyPicture);
            this.Controls.Add(this.debitPicture);
            this.Controls.Add(this.parcelSelector);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.debitSelector);
            this.Controls.Add(this.creditSelector);
            this.Controls.Add(this.moneySelector);
            this.Name = "PaymentMethodSelector";
            this.Size = new System.Drawing.Size(725, 313);
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).EndInit();
            this.customerOnlyPanel.ResumeLayout(false);
            this.customerOnlyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton moneySelector;
        private MetroFramework.Controls.MetroTextBox paidAmountInput;
        private MetroFramework.Controls.MetroRadioButton creditSelector;
        private MetroFramework.Controls.MetroRadioButton debitSelector;
        private MetroFramework.Controls.MetroComboBox customerSelector;
        private MetroFramework.Controls.MetroLabel customerHeader;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox notIdenfityCustomerCheck;
        private MetroFramework.Controls.MetroComboBox parcelSelector;
        private System.Windows.Forms.PictureBox debitPicture;
        private System.Windows.Forms.PictureBox moneyPicture;
        private System.Windows.Forms.PictureBox creditPicture;
        private System.Windows.Forms.Panel customerOnlyPanel;
        private MetroFramework.Controls.MetroLabel returnAmountDisplay;
    }
}
