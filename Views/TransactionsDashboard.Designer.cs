namespace AromasEstoque
{
    partial class TransactionsDashboard
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsDashboard));
            this.transactionsGrid = new MetroFramework.Controls.MetroGrid();
            this.Flow = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.standartReportHeader = new MetroFramework.Controls.MetroLabel();
            this.reportSelector = new MetroFramework.Controls.MetroComboBox();
            this.fromDateHeader = new MetroFramework.Controls.MetroLabel();
            this.fromDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.toDateHeader = new MetroFramework.Controls.MetroLabel();
            this.toDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.dateSelectionPanel = new MetroFramework.Controls.MetroPanel();
            this.incomeDisplay = new System.Windows.Forms.Label();
            this.OutflowDisplay = new System.Windows.Forms.Label();
            this.balanceDisplay = new System.Windows.Forms.Label();
            this.creditDisplay = new System.Windows.Forms.Label();
            this.debitDisplay = new System.Windows.Forms.Label();
            this.moneyDisplay = new System.Windows.Forms.Label();
            this.vaultDisplay = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.vaultPicture = new System.Windows.Forms.PictureBox();
            this.moneyPicture = new System.Windows.Forms.PictureBox();
            this.debitPicture = new System.Windows.Forms.PictureBox();
            this.creditPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OutflowImage = new System.Windows.Forms.PictureBox();
            this.incomeImage = new System.Windows.Forms.PictureBox();
            this.cashierOperationButton = new MetroFramework.Controls.MetroButton();
            this.incomeDetailsPanel = new MetroFramework.Controls.MetroPanel();
            this.comissionButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.dateSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaultPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutflowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeImage)).BeginInit();
            this.incomeDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToResizeRows = false;
            this.transactionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transactionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.transactionsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionsGrid.ColumnHeadersHeight = 40;
            this.transactionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flow,
            this.Id,
            this.Employee,
            this.Information,
            this.Currency,
            this.Date,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.transactionsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionsGrid.EnableHeadersVisualStyles = false;
            this.transactionsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.transactionsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transactionsGrid.Location = new System.Drawing.Point(28, 142);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.transactionsGrid.RowHeadersVisible = false;
            this.transactionsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            this.transactionsGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.transactionsGrid.RowTemplate.Height = 40;
            this.transactionsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(1155, 453);
            this.transactionsGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.transactionsGrid.TabIndex = 0;
            this.transactionsGrid.UseCustomBackColor = true;
            this.transactionsGrid.UseCustomForeColor = true;
            this.transactionsGrid.UseStyleColors = true;
            this.transactionsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TransactionGrid_CellFormatting);
            this.transactionsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TransactionGrid_CellMouseDown);
            // 
            // Flow
            // 
            this.Flow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Flow.DataPropertyName = "Flow";
            this.Flow.HeaderText = "";
            this.Flow.Name = "Flow";
            this.Flow.ReadOnly = true;
            this.Flow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Flow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Flow.Width = 37;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Referência";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 122;
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Funcionário";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 127;
            // 
            // Information
            // 
            this.Information.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Information.DataPropertyName = "Information";
            this.Information.FillWeight = 50F;
            this.Information.HeaderText = "Informações da Transação";
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            // 
            // Currency
            // 
            this.Currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Currency.DataPropertyName = "Currency";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.Currency.DefaultCellStyle = dataGridViewCellStyle2;
            this.Currency.HeaderText = "Moeda";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Width = 97;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.HeaderText = "Data";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 83;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 40;
            // 
            // standartReportHeader
            // 
            this.standartReportHeader.AutoSize = true;
            this.standartReportHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.standartReportHeader.Location = new System.Drawing.Point(23, 67);
            this.standartReportHeader.Name = "standartReportHeader";
            this.standartReportHeader.Size = new System.Drawing.Size(58, 19);
            this.standartReportHeader.TabIndex = 1;
            this.standartReportHeader.Text = "Mostrar";
            // 
            // reportSelector
            // 
            this.reportSelector.FormattingEnabled = true;
            this.reportSelector.ItemHeight = 23;
            this.reportSelector.Items.AddRange(new object[] {
            "Movimentação diária",
            "Movimentação semanal",
            "Movimentação mensal",
            "Selecionar um intervalo"});
            this.reportSelector.Location = new System.Drawing.Point(28, 96);
            this.reportSelector.Name = "reportSelector";
            this.reportSelector.Size = new System.Drawing.Size(215, 29);
            this.reportSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.reportSelector.TabIndex = 2;
            this.reportSelector.UseSelectable = true;
            this.reportSelector.UseStyleColors = true;
            this.reportSelector.SelectedIndexChanged += new System.EventHandler(this.ReportSelector_SelectedIndexChanged);
            // 
            // fromDateHeader
            // 
            this.fromDateHeader.AutoSize = true;
            this.fromDateHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.fromDateHeader.Location = new System.Drawing.Point(6, 12);
            this.fromDateHeader.Name = "fromDateHeader";
            this.fromDateHeader.Size = new System.Drawing.Size(24, 19);
            this.fromDateHeader.TabIndex = 3;
            this.fromDateHeader.Text = "de";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(38, 8);
            this.fromDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(268, 29);
            this.fromDatePicker.Style = MetroFramework.MetroColorStyle.Green;
            this.fromDatePicker.TabIndex = 4;
            this.fromDatePicker.UseStyleColors = true;
            this.fromDatePicker.CloseUp += new System.EventHandler(this.DatePicker_CloseUp);
            // 
            // toDateHeader
            // 
            this.toDateHeader.AutoSize = true;
            this.toDateHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.toDateHeader.Location = new System.Drawing.Point(312, 12);
            this.toDateHeader.Name = "toDateHeader";
            this.toDateHeader.Size = new System.Drawing.Size(28, 19);
            this.toDateHeader.TabIndex = 5;
            this.toDateHeader.Text = "até";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(346, 8);
            this.toDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(268, 29);
            this.toDatePicker.Style = MetroFramework.MetroColorStyle.Green;
            this.toDatePicker.TabIndex = 6;
            this.toDatePicker.CloseUp += new System.EventHandler(this.DatePicker_CloseUp);
            // 
            // dateSelectionPanel
            // 
            this.dateSelectionPanel.Controls.Add(this.toDatePicker);
            this.dateSelectionPanel.Controls.Add(this.toDateHeader);
            this.dateSelectionPanel.Controls.Add(this.fromDatePicker);
            this.dateSelectionPanel.Controls.Add(this.fromDateHeader);
            this.dateSelectionPanel.HorizontalScrollbarBarColor = true;
            this.dateSelectionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.dateSelectionPanel.HorizontalScrollbarSize = 10;
            this.dateSelectionPanel.Location = new System.Drawing.Point(260, 88);
            this.dateSelectionPanel.Name = "dateSelectionPanel";
            this.dateSelectionPanel.Size = new System.Drawing.Size(640, 46);
            this.dateSelectionPanel.TabIndex = 7;
            this.dateSelectionPanel.VerticalScrollbarBarColor = true;
            this.dateSelectionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.dateSelectionPanel.VerticalScrollbarSize = 10;
            this.dateSelectionPanel.Visible = false;
            // 
            // incomeDisplay
            // 
            this.incomeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incomeDisplay.AutoSize = true;
            this.incomeDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.incomeDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeDisplay.Location = new System.Drawing.Point(46, 676);
            this.incomeDisplay.Name = "incomeDisplay";
            this.incomeDisplay.Size = new System.Drawing.Size(137, 17);
            this.incomeDisplay.TabIndex = 8;
            this.incomeDisplay.Text = "Entrada total: R$ 0,00";
            this.incomeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incomeDisplay.MouseEnter += new System.EventHandler(this.IncomeDisplay_MouseEnter);
            this.incomeDisplay.MouseLeave += new System.EventHandler(this.IncomeDisplay_MouseLeave);
            // 
            // OutflowDisplay
            // 
            this.OutflowDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutflowDisplay.AutoSize = true;
            this.OutflowDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutflowDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OutflowDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutflowDisplay.Location = new System.Drawing.Point(257, 675);
            this.OutflowDisplay.Name = "OutflowDisplay";
            this.OutflowDisplay.Size = new System.Drawing.Size(122, 17);
            this.OutflowDisplay.TabIndex = 9;
            this.OutflowDisplay.Text = "Saída total: R$ 0,00";
            this.OutflowDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balanceDisplay
            // 
            this.balanceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balanceDisplay.AutoSize = true;
            this.balanceDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.balanceDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceDisplay.Location = new System.Drawing.Point(445, 675);
            this.balanceDisplay.Name = "balanceDisplay";
            this.balanceDisplay.Size = new System.Drawing.Size(105, 17);
            this.balanceDisplay.TabIndex = 13;
            this.balanceDisplay.Text = "Balanço: R$ 0,00";
            this.balanceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creditDisplay
            // 
            this.creditDisplay.AutoSize = true;
            this.creditDisplay.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.creditDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditDisplay.Location = new System.Drawing.Point(36, 41);
            this.creditDisplay.Name = "creditDisplay";
            this.creditDisplay.Size = new System.Drawing.Size(133, 14);
            this.creditDisplay.TabIndex = 15;
            this.creditDisplay.Text = "Cartão de crédito: R$ 0,00";
            this.creditDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // debitDisplay
            // 
            this.debitDisplay.AutoSize = true;
            this.debitDisplay.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.debitDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debitDisplay.Location = new System.Drawing.Point(36, 61);
            this.debitDisplay.Name = "debitDisplay";
            this.debitDisplay.Size = new System.Drawing.Size(81, 14);
            this.debitDisplay.TabIndex = 17;
            this.debitDisplay.Text = "Débito: R$ 0,00";
            this.debitDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moneyDisplay
            // 
            this.moneyDisplay.AutoSize = true;
            this.moneyDisplay.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.moneyDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyDisplay.Location = new System.Drawing.Point(36, 21);
            this.moneyDisplay.Name = "moneyDisplay";
            this.moneyDisplay.Size = new System.Drawing.Size(90, 14);
            this.moneyDisplay.TabIndex = 18;
            this.moneyDisplay.Text = "Dinheiro: R$ 0,00";
            this.moneyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vaultDisplay
            // 
            this.vaultDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vaultDisplay.AutoSize = true;
            this.vaultDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaultDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.vaultDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vaultDisplay.Location = new System.Drawing.Point(617, 677);
            this.vaultDisplay.Name = "vaultDisplay";
            this.vaultDisplay.Size = new System.Drawing.Size(146, 17);
            this.vaultDisplay.TabIndex = 21;
            this.vaultDisplay.Text = "Total em Caixa: R$ 0,00";
            this.vaultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // vaultPicture
            // 
            this.vaultPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vaultPicture.Image = ((System.Drawing.Image)(resources.GetObject("vaultPicture.Image")));
            this.vaultPicture.Location = new System.Drawing.Point(597, 678);
            this.vaultPicture.Name = "vaultPicture";
            this.vaultPicture.Size = new System.Drawing.Size(16, 16);
            this.vaultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vaultPicture.TabIndex = 20;
            this.vaultPicture.TabStop = false;
            // 
            // moneyPicture
            // 
            this.moneyPicture.Image = ((System.Drawing.Image)(resources.GetObject("moneyPicture.Image")));
            this.moneyPicture.Location = new System.Drawing.Point(17, 20);
            this.moneyPicture.Name = "moneyPicture";
            this.moneyPicture.Size = new System.Drawing.Size(16, 16);
            this.moneyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.moneyPicture.TabIndex = 19;
            this.moneyPicture.TabStop = false;
            // 
            // debitPicture
            // 
            this.debitPicture.Image = ((System.Drawing.Image)(resources.GetObject("debitPicture.Image")));
            this.debitPicture.Location = new System.Drawing.Point(17, 60);
            this.debitPicture.Name = "debitPicture";
            this.debitPicture.Size = new System.Drawing.Size(16, 16);
            this.debitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.debitPicture.TabIndex = 16;
            this.debitPicture.TabStop = false;
            // 
            // creditPicture
            // 
            this.creditPicture.Image = ((System.Drawing.Image)(resources.GetObject("creditPicture.Image")));
            this.creditPicture.Location = new System.Drawing.Point(17, 40);
            this.creditPicture.Name = "creditPicture";
            this.creditPicture.Size = new System.Drawing.Size(16, 16);
            this.creditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creditPicture.TabIndex = 14;
            this.creditPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 676);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // OutflowImage
            // 
            this.OutflowImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutflowImage.Image = global::AromasEstoque.Properties.Resources.down_arrow;
            this.OutflowImage.Location = new System.Drawing.Point(237, 676);
            this.OutflowImage.Name = "OutflowImage";
            this.OutflowImage.Size = new System.Drawing.Size(16, 16);
            this.OutflowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OutflowImage.TabIndex = 11;
            this.OutflowImage.TabStop = false;
            // 
            // incomeImage
            // 
            this.incomeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incomeImage.Image = global::AromasEstoque.Properties.Resources.up_arrow;
            this.incomeImage.Location = new System.Drawing.Point(27, 677);
            this.incomeImage.Name = "incomeImage";
            this.incomeImage.Size = new System.Drawing.Size(16, 16);
            this.incomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.incomeImage.TabIndex = 10;
            this.incomeImage.TabStop = false;
            // 
            // cashierOperationButton
            // 
            this.cashierOperationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cashierOperationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cashierOperationButton.Highlight = true;
            this.cashierOperationButton.Location = new System.Drawing.Point(1000, 666);
            this.cashierOperationButton.Name = "cashierOperationButton";
            this.cashierOperationButton.Size = new System.Drawing.Size(183, 28);
            this.cashierOperationButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cashierOperationButton.TabIndex = 22;
            this.cashierOperationButton.Text = "Operações de Caixa";
            this.cashierOperationButton.UseSelectable = true;
            this.cashierOperationButton.UseStyleColors = true;
            this.cashierOperationButton.Click += new System.EventHandler(this.CashierOperationButton_Click);
            // 
            // incomeDetailsPanel
            // 
            this.incomeDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incomeDetailsPanel.Controls.Add(this.moneyPicture);
            this.incomeDetailsPanel.Controls.Add(this.moneyDisplay);
            this.incomeDetailsPanel.Controls.Add(this.debitDisplay);
            this.incomeDetailsPanel.Controls.Add(this.debitPicture);
            this.incomeDetailsPanel.Controls.Add(this.creditDisplay);
            this.incomeDetailsPanel.Controls.Add(this.creditPicture);
            this.incomeDetailsPanel.HorizontalScrollbarBarColor = true;
            this.incomeDetailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.incomeDetailsPanel.HorizontalScrollbarSize = 10;
            this.incomeDetailsPanel.Location = new System.Drawing.Point(10, 597);
            this.incomeDetailsPanel.Name = "incomeDetailsPanel";
            this.incomeDetailsPanel.Size = new System.Drawing.Size(191, 81);
            this.incomeDetailsPanel.TabIndex = 23;
            this.incomeDetailsPanel.VerticalScrollbarBarColor = true;
            this.incomeDetailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.incomeDetailsPanel.VerticalScrollbarSize = 10;
            this.incomeDetailsPanel.Visible = false;
            // 
            // comissionButton
            // 
            this.comissionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comissionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.comissionButton.Highlight = true;
            this.comissionButton.Location = new System.Drawing.Point(811, 666);
            this.comissionButton.Name = "comissionButton";
            this.comissionButton.Size = new System.Drawing.Size(183, 28);
            this.comissionButton.Style = MetroFramework.MetroColorStyle.Green;
            this.comissionButton.TabIndex = 24;
            this.comissionButton.Text = "Cálculo de Comissão";
            this.comissionButton.UseSelectable = true;
            this.comissionButton.UseStyleColors = true;
            this.comissionButton.Click += new System.EventHandler(this.ComissionButton_Click);
            // 
            // TransactionsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 713);
            this.Controls.Add(this.comissionButton);
            this.Controls.Add(this.incomeDetailsPanel);
            this.Controls.Add(this.cashierOperationButton);
            this.Controls.Add(this.vaultDisplay);
            this.Controls.Add(this.vaultPicture);
            this.Controls.Add(this.balanceDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutflowImage);
            this.Controls.Add(this.incomeImage);
            this.Controls.Add(this.OutflowDisplay);
            this.Controls.Add(this.incomeDisplay);
            this.Controls.Add(this.dateSelectionPanel);
            this.Controls.Add(this.reportSelector);
            this.Controls.Add(this.standartReportHeader);
            this.Controls.Add(this.transactionsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionsDashboard";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Movimentação financeira";
            this.Load += new System.EventHandler(this.TransactionsDashboard_Load);
            this.Shown += new System.EventHandler(this.TransactionsDashboard_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.dateSelectionPanel.ResumeLayout(false);
            this.dateSelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaultPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutflowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeImage)).EndInit();
            this.incomeDetailsPanel.ResumeLayout(false);
            this.incomeDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid transactionsGrid;
        private MetroFramework.Controls.MetroLabel standartReportHeader;
        private MetroFramework.Controls.MetroComboBox reportSelector;
        private MetroFramework.Controls.MetroLabel fromDateHeader;
        private MetroFramework.Controls.MetroDateTime fromDatePicker;
        private MetroFramework.Controls.MetroLabel toDateHeader;
        private MetroFramework.Controls.MetroDateTime toDatePicker;
        private MetroFramework.Controls.MetroPanel dateSelectionPanel;
        private System.Windows.Forms.DataGridViewImageColumn Flow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label incomeDisplay;
        private System.Windows.Forms.Label OutflowDisplay;
        private System.Windows.Forms.PictureBox incomeImage;
        private System.Windows.Forms.PictureBox OutflowImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label balanceDisplay;
        private System.Windows.Forms.Label creditDisplay;
        private System.Windows.Forms.PictureBox creditPicture;
        private System.Windows.Forms.Label debitDisplay;
        private System.Windows.Forms.PictureBox debitPicture;
        private System.Windows.Forms.PictureBox moneyPicture;
        private System.Windows.Forms.Label moneyDisplay;
        private System.Windows.Forms.Label vaultDisplay;
        private System.Windows.Forms.PictureBox vaultPicture;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private MetroFramework.Controls.MetroButton cashierOperationButton;
        private MetroFramework.Controls.MetroPanel incomeDetailsPanel;
        private MetroFramework.Controls.MetroButton comissionButton;
    }
}

