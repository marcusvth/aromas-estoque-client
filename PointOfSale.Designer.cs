namespace AromasEstoque
{
    partial class PointOfSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cartGrid = new MetroFramework.Controls.MetroGrid();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReduceAmount = new System.Windows.Forms.DataGridViewImageColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncreaseAmount = new System.Windows.Forms.DataGridViewImageColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalUnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.saleNavigation = new MetroFramework.Controls.MetroTabControl();
            this.newSalePage = new MetroFramework.Controls.MetroTabPage();
            this.successPicture = new System.Windows.Forms.PictureBox();
            this.cancelSaleButton = new MetroFramework.Controls.MetroButton();
            this.paymentMethodButton = new MetroFramework.Controls.MetroButton();
            this.addToCartButton = new MetroFramework.Controls.MetroButton();
            this.searchInput = new MetroFramework.Controls.MetroTextBox();
            this.productSelector = new MetroFramework.Controls.MetroComboBox();
            this.paymentTab = new MetroFramework.Controls.MetroTabPage();
            this.finishSaleButton = new MetroFramework.Controls.MetroButton();
            this.paymentMethodPanel = new System.Windows.Forms.Panel();
            this.discountPanel = new System.Windows.Forms.Panel();
            this.percentDiscountSelector = new MetroFramework.Controls.MetroRadioButton();
            this.moneyDiscountSelector = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.discountPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.moneyDiscountInput = new MetroFramework.Controls.MetroTextBox();
            this.discountToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.totalPriceDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.saleNavigation.SuspendLayout();
            this.newSalePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successPicture)).BeginInit();
            this.paymentTab.SuspendLayout();
            this.discountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cartGrid
            // 
            this.cartGrid.AllowUserToAddRows = false;
            this.cartGrid.AllowUserToResizeRows = false;
            this.cartGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cartGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNumber,
            this.ProductNameColumn,
            this.ReduceAmount,
            this.Amount,
            this.IncreaseAmount,
            this.UnitPrice,
            this.TotalUnitPriceColumn,
            this.Delete});
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartGrid.DefaultCellStyle = dataGridViewCellStyle47;
            this.cartGrid.EnableHeadersVisualStyles = false;
            this.cartGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cartGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cartGrid.Location = new System.Drawing.Point(0, 72);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.cartGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cartGrid.RowTemplate.Height = 40;
            this.cartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGrid.Size = new System.Drawing.Size(1076, 342);
            this.cartGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.cartGrid.TabIndex = 2;
            this.cartGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsGrid_CellMouseDown);
            // 
            // ProductNumber
            // 
            this.ProductNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductNumber.HeaderText = "Nº";
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.ReadOnly = true;
            this.ProductNumber.Width = 43;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Nome do Produto";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ReduceAmount
            // 
            this.ReduceAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReduceAmount.HeaderText = "";
            this.ReduceAmount.Image = ((System.Drawing.Image)(resources.GetObject("ReduceAmount.Image")));
            this.ReduceAmount.Name = "ReduceAmount";
            this.ReduceAmount.ReadOnly = true;
            this.ReduceAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReduceAmount.Width = 5;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle44;
            this.Amount.HeaderText = "Quantidade";
            this.Amount.Name = "Amount";
            this.Amount.Width = 91;
            // 
            // IncreaseAmount
            // 
            this.IncreaseAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IncreaseAmount.HeaderText = "";
            this.IncreaseAmount.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseAmount.Image")));
            this.IncreaseAmount.Name = "IncreaseAmount";
            this.IncreaseAmount.ReadOnly = true;
            this.IncreaseAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IncreaseAmount.Width = 5;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.Format = "C2";
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle45;
            this.UnitPrice.HeaderText = "Valor Unitário";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 93;
            // 
            // TotalUnitPriceColumn
            // 
            this.TotalUnitPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.Format = "C2";
            this.TotalUnitPriceColumn.DefaultCellStyle = dataGridViewCellStyle46;
            this.TotalUnitPriceColumn.HeaderText = "Valor Total";
            this.TotalUnitPriceColumn.Name = "TotalUnitPriceColumn";
            this.TotalUnitPriceColumn.ReadOnly = true;
            this.TotalUnitPriceColumn.Width = 77;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::AromasEstoque.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // saleNavigation
            // 
            this.saleNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleNavigation.Controls.Add(this.newSalePage);
            this.saleNavigation.Controls.Add(this.paymentTab);
            this.saleNavigation.Location = new System.Drawing.Point(23, 64);
            this.saleNavigation.Name = "saleNavigation";
            this.saleNavigation.SelectedIndex = 1;
            this.saleNavigation.Size = new System.Drawing.Size(1089, 500);
            this.saleNavigation.Style = MetroFramework.MetroColorStyle.Green;
            this.saleNavigation.TabIndex = 3;
            this.saleNavigation.UseSelectable = true;
            // 
            // newSalePage
            // 
            this.newSalePage.Controls.Add(this.successPicture);
            this.newSalePage.Controls.Add(this.cancelSaleButton);
            this.newSalePage.Controls.Add(this.paymentMethodButton);
            this.newSalePage.Controls.Add(this.addToCartButton);
            this.newSalePage.Controls.Add(this.searchInput);
            this.newSalePage.Controls.Add(this.productSelector);
            this.newSalePage.Controls.Add(this.cartGrid);
            this.newSalePage.HorizontalScrollbarBarColor = true;
            this.newSalePage.HorizontalScrollbarHighlightOnWheel = false;
            this.newSalePage.HorizontalScrollbarSize = 10;
            this.newSalePage.Location = new System.Drawing.Point(4, 38);
            this.newSalePage.Name = "newSalePage";
            this.newSalePage.Size = new System.Drawing.Size(1081, 458);
            this.newSalePage.TabIndex = 0;
            this.newSalePage.Text = "Nova venda";
            this.newSalePage.VerticalScrollbarBarColor = true;
            this.newSalePage.VerticalScrollbarHighlightOnWheel = false;
            this.newSalePage.VerticalScrollbarSize = 10;
            // 
            // successPicture
            // 
            this.successPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.successPicture.Image = ((System.Drawing.Image)(resources.GetObject("successPicture.Image")));
            this.successPicture.Location = new System.Drawing.Point(414, 134);
            this.successPicture.Name = "successPicture";
            this.successPicture.Size = new System.Drawing.Size(252, 191);
            this.successPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.successPicture.TabIndex = 12;
            this.successPicture.TabStop = false;
            this.successPicture.Visible = false;
            // 
            // cancelSaleButton
            // 
            this.cancelSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSaleButton.Highlight = true;
            this.cancelSaleButton.Location = new System.Drawing.Point(684, 423);
            this.cancelSaleButton.Name = "cancelSaleButton";
            this.cancelSaleButton.Size = new System.Drawing.Size(191, 35);
            this.cancelSaleButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelSaleButton.TabIndex = 11;
            this.cancelSaleButton.Text = "Cancelar venda";
            this.cancelSaleButton.UseSelectable = true;
            this.cancelSaleButton.UseStyleColors = true;
            this.cancelSaleButton.Click += new System.EventHandler(this.CancelSaleButton_Click);
            // 
            // paymentMethodButton
            // 
            this.paymentMethodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentMethodButton.Highlight = true;
            this.paymentMethodButton.Location = new System.Drawing.Point(881, 423);
            this.paymentMethodButton.Name = "paymentMethodButton";
            this.paymentMethodButton.Size = new System.Drawing.Size(191, 35);
            this.paymentMethodButton.Style = MetroFramework.MetroColorStyle.Green;
            this.paymentMethodButton.TabIndex = 10;
            this.paymentMethodButton.Text = "Ir para forma de pagamento";
            this.paymentMethodButton.UseSelectable = true;
            this.paymentMethodButton.UseStyleColors = true;
            this.paymentMethodButton.Click += new System.EventHandler(this.PaymentMethodButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(924, 31);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(152, 35);
            this.addToCartButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addToCartButton.TabIndex = 5;
            this.addToCartButton.Text = "Adicionar ao carrinho";
            this.addToCartButton.UseSelectable = true;
            this.addToCartButton.UseStyleColors = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // searchInput
            // 
            // 
            // 
            // 
            this.searchInput.CustomButton.Image = null;
            this.searchInput.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.searchInput.CustomButton.Name = "";
            this.searchInput.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.searchInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchInput.CustomButton.TabIndex = 1;
            this.searchInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchInput.CustomButton.UseSelectable = true;
            this.searchInput.CustomButton.Visible = false;
            this.searchInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchInput.Lines = new string[0];
            this.searchInput.Location = new System.Drawing.Point(3, 31);
            this.searchInput.MaxLength = 32767;
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PromptText = "Insira o código ou nome do produto, ou selecione na lista ao lado";
            this.searchInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchInput.SelectedText = "";
            this.searchInput.SelectionLength = 0;
            this.searchInput.SelectionStart = 0;
            this.searchInput.ShortcutsEnabled = true;
            this.searchInput.Size = new System.Drawing.Size(357, 35);
            this.searchInput.Style = MetroFramework.MetroColorStyle.Green;
            this.searchInput.TabIndex = 4;
            this.searchInput.UseSelectable = true;
            this.searchInput.UseStyleColors = true;
            this.searchInput.WaterMark = "Insira o código ou nome do produto, ou selecione na lista ao lado";
            this.searchInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchInput.TextChanged += new System.EventHandler(this.ProductInput_TextChanged);
            this.searchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyDown);
            // 
            // productSelector
            // 
            this.productSelector.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.productSelector.FormattingEnabled = true;
            this.productSelector.ItemHeight = 29;
            this.productSelector.Location = new System.Drawing.Point(366, 31);
            this.productSelector.Name = "productSelector";
            this.productSelector.Size = new System.Drawing.Size(552, 35);
            this.productSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.productSelector.TabIndex = 3;
            this.productSelector.UseSelectable = true;
            // 
            // paymentTab
            // 
            this.paymentTab.Controls.Add(this.finishSaleButton);
            this.paymentTab.Controls.Add(this.paymentMethodPanel);
            this.paymentTab.HorizontalScrollbarBarColor = true;
            this.paymentTab.HorizontalScrollbarHighlightOnWheel = false;
            this.paymentTab.HorizontalScrollbarSize = 10;
            this.paymentTab.Location = new System.Drawing.Point(4, 38);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Size = new System.Drawing.Size(1081, 458);
            this.paymentTab.Style = MetroFramework.MetroColorStyle.Green;
            this.paymentTab.TabIndex = 1;
            this.paymentTab.Text = "Forma de pagamento";
            this.paymentTab.VerticalScrollbarBarColor = true;
            this.paymentTab.VerticalScrollbarHighlightOnWheel = false;
            this.paymentTab.VerticalScrollbarSize = 10;
            // 
            // finishSaleButton
            // 
            this.finishSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishSaleButton.Enabled = false;
            this.finishSaleButton.Highlight = true;
            this.finishSaleButton.Location = new System.Drawing.Point(881, 423);
            this.finishSaleButton.Name = "finishSaleButton";
            this.finishSaleButton.Size = new System.Drawing.Size(191, 35);
            this.finishSaleButton.Style = MetroFramework.MetroColorStyle.Green;
            this.finishSaleButton.TabIndex = 11;
            this.finishSaleButton.Text = "Finalizar a venda";
            this.finishSaleButton.UseSelectable = true;
            this.finishSaleButton.UseStyleColors = true;
            this.finishSaleButton.Click += new System.EventHandler(this.FinishSaleButton_Click);
            // 
            // paymentMethodPanel
            // 
            this.paymentMethodPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentMethodPanel.BackColor = System.Drawing.Color.White;
            this.paymentMethodPanel.Location = new System.Drawing.Point(164, 73);
            this.paymentMethodPanel.Name = "paymentMethodPanel";
            this.paymentMethodPanel.Size = new System.Drawing.Size(725, 313);
            this.paymentMethodPanel.TabIndex = 2;
            // 
            // discountPanel
            // 
            this.discountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discountPanel.BackColor = System.Drawing.Color.White;
            this.discountPanel.Controls.Add(this.percentDiscountSelector);
            this.discountPanel.Controls.Add(this.moneyDiscountSelector);
            this.discountPanel.Controls.Add(this.metroLabel3);
            this.discountPanel.Controls.Add(this.discountPercentageInput);
            this.discountPanel.Controls.Add(this.metroLabel2);
            this.discountPanel.Controls.Add(this.moneyDiscountInput);
            this.discountPanel.Location = new System.Drawing.Point(219, 603);
            this.discountPanel.Name = "discountPanel";
            this.discountPanel.Size = new System.Drawing.Size(260, 30);
            this.discountPanel.TabIndex = 9;
            this.discountPanel.Visible = false;
            // 
            // percentDiscountSelector
            // 
            this.percentDiscountSelector.AutoSize = true;
            this.percentDiscountSelector.Location = new System.Drawing.Point(124, 8);
            this.percentDiscountSelector.Name = "percentDiscountSelector";
            this.percentDiscountSelector.Size = new System.Drawing.Size(26, 15);
            this.percentDiscountSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.percentDiscountSelector.TabIndex = 14;
            this.percentDiscountSelector.Text = " ";
            this.percentDiscountSelector.UseSelectable = true;
            this.percentDiscountSelector.CheckedChanged += new System.EventHandler(this.DiscountSelectors_CheckedChanged);
            // 
            // moneyDiscountSelector
            // 
            this.moneyDiscountSelector.AutoSize = true;
            this.moneyDiscountSelector.Checked = true;
            this.moneyDiscountSelector.Location = new System.Drawing.Point(3, 8);
            this.moneyDiscountSelector.Name = "moneyDiscountSelector";
            this.moneyDiscountSelector.Size = new System.Drawing.Size(26, 15);
            this.moneyDiscountSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.moneyDiscountSelector.TabIndex = 13;
            this.moneyDiscountSelector.TabStop = true;
            this.moneyDiscountSelector.Text = " ";
            this.moneyDiscountSelector.UseSelectable = true;
            this.moneyDiscountSelector.CheckedChanged += new System.EventHandler(this.DiscountSelectors_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(232, 6);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(20, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "%";
            // 
            // discountPercentageInput
            // 
            this.discountPercentageInput.Enabled = false;
            this.discountPercentageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.discountPercentageInput.Location = new System.Drawing.Point(153, 4);
            this.discountPercentageInput.Name = "discountPercentageInput";
            this.discountPercentageInput.Size = new System.Drawing.Size(75, 23);
            this.discountPercentageInput.TabIndex = 11;
            this.discountPercentageInput.ValueChanged += new System.EventHandler(this.MoneyInputs_InputChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "R$";
            // 
            // moneyDiscountInput
            // 
            // 
            // 
            // 
            this.moneyDiscountInput.CustomButton.Image = null;
            this.moneyDiscountInput.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.moneyDiscountInput.CustomButton.Name = "";
            this.moneyDiscountInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.moneyDiscountInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.moneyDiscountInput.CustomButton.TabIndex = 1;
            this.moneyDiscountInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.moneyDiscountInput.CustomButton.UseSelectable = true;
            this.moneyDiscountInput.CustomButton.Visible = false;
            this.moneyDiscountInput.Lines = new string[] {
        "0,00"};
            this.moneyDiscountInput.Location = new System.Drawing.Point(61, 4);
            this.moneyDiscountInput.MaxLength = 32767;
            this.moneyDiscountInput.Name = "moneyDiscountInput";
            this.moneyDiscountInput.PasswordChar = '\0';
            this.moneyDiscountInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.moneyDiscountInput.SelectedText = "";
            this.moneyDiscountInput.SelectionLength = 0;
            this.moneyDiscountInput.SelectionStart = 0;
            this.moneyDiscountInput.ShortcutsEnabled = true;
            this.moneyDiscountInput.Size = new System.Drawing.Size(59, 23);
            this.moneyDiscountInput.Style = MetroFramework.MetroColorStyle.Green;
            this.moneyDiscountInput.TabIndex = 0;
            this.moneyDiscountInput.Text = "0,00";
            this.moneyDiscountInput.UseSelectable = true;
            this.moneyDiscountInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.moneyDiscountInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.moneyDiscountInput.TextChanged += new System.EventHandler(this.MoneyInputs_InputChanged);
            this.moneyDiscountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoneyDiscountInput_KeyDown);
            this.moneyDiscountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoneyInputs_HandledKeyPress);
            // 
            // discountToggle
            // 
            this.discountToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discountToggle.AutoSize = true;
            this.discountToggle.DisplayStatus = false;
            this.discountToggle.Location = new System.Drawing.Point(385, 583);
            this.discountToggle.Name = "discountToggle";
            this.discountToggle.Size = new System.Drawing.Size(50, 17);
            this.discountToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.discountToggle.TabIndex = 8;
            this.discountToggle.Text = "Off";
            this.discountToggle.UseSelectable = true;
            this.discountToggle.CheckedChanged += new System.EventHandler(this.DiscountToggle_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(258, 581);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Conceder desconto";
            // 
            // totalPriceDisplay
            // 
            this.totalPriceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceDisplay.AutoSize = true;
            this.totalPriceDisplay.BackColor = System.Drawing.Color.White;
            this.totalPriceDisplay.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.totalPriceDisplay.Location = new System.Drawing.Point(16, 577);
            this.totalPriceDisplay.Name = "totalPriceDisplay";
            this.totalPriceDisplay.Size = new System.Drawing.Size(166, 37);
            this.totalPriceDisplay.TabIndex = 6;
            this.totalPriceDisplay.Text = "Total: R$ 0,00";
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 656);
            this.Controls.Add(this.saleNavigation);
            this.Controls.Add(this.totalPriceDisplay);
            this.Controls.Add(this.discountPanel);
            this.Controls.Add(this.discountToggle);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PointOfSale";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Aromas - Ponto de venda";
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.saleNavigation.ResumeLayout(false);
            this.newSalePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.successPicture)).EndInit();
            this.paymentTab.ResumeLayout(false);
            this.discountPanel.ResumeLayout(false);
            this.discountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentageInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid cartGrid;
        private MetroFramework.Controls.MetroTabControl saleNavigation;
        private MetroFramework.Controls.MetroTabPage newSalePage;
        private MetroFramework.Controls.MetroTabPage paymentTab;
        private MetroFramework.Controls.MetroTextBox searchInput;
        private MetroFramework.Controls.MetroComboBox productSelector;
        private MetroFramework.Controls.MetroButton addToCartButton;
        private System.Windows.Forms.Label totalPriceDisplay;
        private System.Windows.Forms.Panel discountPanel;
        private MetroFramework.Controls.MetroRadioButton percentDiscountSelector;
        private MetroFramework.Controls.MetroRadioButton moneyDiscountSelector;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown discountPercentageInput;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox moneyDiscountInput;
        private MetroFramework.Controls.MetroToggle discountToggle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton paymentMethodButton;
        private System.Windows.Forms.Panel paymentMethodPanel;
        private MetroFramework.Controls.MetroButton finishSaleButton;
        private MetroFramework.Controls.MetroButton cancelSaleButton;
        private System.Windows.Forms.PictureBox successPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewImageColumn ReduceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn IncreaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalUnitPriceColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}