namespace AromasEstoque
{
    partial class PendingPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingPayments));
            this.pendingGrid = new MetroFramework.Controls.MetroGrid();
            this.RefId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.filterByCustomerSelector = new MetroFramework.Controls.MetroCheckBox();
            this.totalCustomerDebtDisplay = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pendingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingGrid
            // 
            this.pendingGrid.AllowUserToAddRows = false;
            this.pendingGrid.AllowUserToDeleteRows = false;
            this.pendingGrid.AllowUserToResizeRows = false;
            this.pendingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pendingGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pendingGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pendingGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pendingGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pendingGrid.ColumnHeadersHeight = 40;
            this.pendingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefId,
            this.Category,
            this.Customer,
            this.EventDate,
            this.Total,
            this.PaidAmount,
            this.Pay});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.pendingGrid.EnableHeadersVisualStyles = false;
            this.pendingGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pendingGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pendingGrid.Location = new System.Drawing.Point(23, 114);
            this.pendingGrid.Name = "pendingGrid";
            this.pendingGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.pendingGrid.RowHeadersVisible = false;
            this.pendingGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pendingGrid.RowTemplate.Height = 40;
            this.pendingGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendingGrid.Size = new System.Drawing.Size(930, 425);
            this.pendingGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.pendingGrid.TabIndex = 8;
            this.pendingGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PendingGrid_CellMouseDown);
            this.pendingGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.pendingGrid_CellMouseEnter);
            this.pendingGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.pendingGrid_DataBindingComplete);
            // 
            // RefId
            // 
            this.RefId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RefId.DataPropertyName = "RefId";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.RefId.DefaultCellStyle = dataGridViewCellStyle2;
            this.RefId.HeaderText = "Nº";
            this.RefId.Name = "RefId";
            this.RefId.Width = 49;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Categoria";
            this.Category.Name = "Category";
            this.Category.Width = 95;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.DataPropertyName = "Customer";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.Customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.Customer.HeaderText = "Cliente";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // EventDate
            // 
            this.EventDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventDate.DataPropertyName = "EventDate";
            dataGridViewCellStyle4.Format = "D";
            this.EventDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.EventDate.HeaderText = "Data da Compra";
            this.EventDate.Name = "EventDate";
            this.EventDate.Width = 125;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Valor Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 93;
            // 
            // PaidAmount
            // 
            this.PaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaidAmount.DataPropertyName = "PaidAmount";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            this.PaidAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.PaidAmount.HeaderText = "Valor Pago";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.Width = 93;
            // 
            // Pay
            // 
            this.Pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pay.HeaderText = "";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Pay.Text = "Regularizar";
            this.Pay.UseColumnTextForButtonValue = true;
            this.Pay.Width = 17;
            // 
            // customerPanel
            // 
            this.customerPanel.Enabled = false;
            this.customerPanel.Location = new System.Drawing.Point(147, 557);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(682, 73);
            this.customerPanel.TabIndex = 9;
            // 
            // filterByCustomerSelector
            // 
            this.filterByCustomerSelector.AutoSize = true;
            this.filterByCustomerSelector.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.filterByCustomerSelector.Location = new System.Drawing.Point(408, 639);
            this.filterByCustomerSelector.Name = "filterByCustomerSelector";
            this.filterByCustomerSelector.Size = new System.Drawing.Size(160, 25);
            this.filterByCustomerSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.filterByCustomerSelector.TabIndex = 10;
            this.filterByCustomerSelector.Text = "Filtrar por cliente";
            this.filterByCustomerSelector.UseSelectable = true;
            this.filterByCustomerSelector.CheckedChanged += new System.EventHandler(this.FilterByCustomerSelector_CheckedChanged);
            // 
            // totalCustomerDebtDisplay
            // 
            this.totalCustomerDebtDisplay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalCustomerDebtDisplay.Location = new System.Drawing.Point(23, 81);
            this.totalCustomerDebtDisplay.Name = "totalCustomerDebtDisplay";
            this.totalCustomerDebtDisplay.Size = new System.Drawing.Size(930, 23);
            this.totalCustomerDebtDisplay.TabIndex = 11;
            this.totalCustomerDebtDisplay.Text = "Débito total: R$0,00";
            this.totalCustomerDebtDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalCustomerDebtDisplay.Visible = false;
            // 
            // PendingPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 687);
            this.Controls.Add(this.totalCustomerDebtDisplay);
            this.Controls.Add(this.filterByCustomerSelector);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.pendingGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PendingPayments";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pagamentos pendentes";
            ((System.ComponentModel.ISupportInitialize)(this.pendingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid pendingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewButtonColumn Pay;
        private System.Windows.Forms.Panel customerPanel;
        private MetroFramework.Controls.MetroCheckBox filterByCustomerSelector;
        private MetroFramework.Controls.MetroLabel totalCustomerDebtDisplay;
    }
}