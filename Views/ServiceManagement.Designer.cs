namespace AromasEstoque
{
    partial class ServiceManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagement));
            this.serviceGrid = new MetroFramework.Controls.MetroGrid();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.providerManagementButton = new MetroFramework.Controls.MetroButton();
            this.monthlyTotalDisplay = new System.Windows.Forms.Label();
            this.dateTimePanel = new System.Windows.Forms.Panel();
            this.filterByDateSelector = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceGrid
            // 
            this.serviceGrid.AllowUserToAddRows = false;
            this.serviceGrid.AllowUserToDeleteRows = false;
            this.serviceGrid.AllowUserToResizeRows = false;
            this.serviceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.serviceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serviceGrid.ColumnHeadersHeight = 40;
            this.serviceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobId,
            this.EventDate,
            this.Service,
            this.FullName,
            this.CustomerName,
            this.TotalPrice,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.serviceGrid.EnableHeadersVisualStyles = false;
            this.serviceGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serviceGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceGrid.Location = new System.Drawing.Point(27, 98);
            this.serviceGrid.Name = "serviceGrid";
            this.serviceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.serviceGrid.RowHeadersVisible = false;
            this.serviceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serviceGrid.RowTemplate.Height = 40;
            this.serviceGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceGrid.Size = new System.Drawing.Size(867, 409);
            this.serviceGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.serviceGrid.TabIndex = 7;
            this.serviceGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceGrid_CellMouseDown);
            this.serviceGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ServiceGrid_DatabindingComplete);
            // 
            // JobId
            // 
            this.JobId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JobId.DataPropertyName = "JobId";
            this.JobId.HeaderText = "Nº";
            this.JobId.Name = "JobId";
            this.JobId.Width = 69;
            // 
            // EventDate
            // 
            this.EventDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventDate.DataPropertyName = "EventDate";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.EventDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.EventDate.HeaderText = "Data";
            this.EventDate.Name = "EventDate";
            this.EventDate.ReadOnly = true;
            this.EventDate.Width = 83;
            // 
            // Service
            // 
            this.Service.DataPropertyName = "Service";
            this.Service.HeaderText = "Serviço";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Prestador";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Cliente";
            this.CustomerName.Name = "CustomerName";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle3.Format = "C";
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalPrice.HeaderText = "Valor Total";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 121;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::AromasEstoque.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 37;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AromasEstoque.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addButton
            // 
            this.addButton.Highlight = true;
            this.addButton.Location = new System.Drawing.Point(27, 58);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(177, 34);
            this.addButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Registrar novo serviço";
            this.addButton.UseSelectable = true;
            this.addButton.UseStyleColors = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // providerManagementButton
            // 
            this.providerManagementButton.Highlight = true;
            this.providerManagementButton.Location = new System.Drawing.Point(216, 58);
            this.providerManagementButton.Name = "providerManagementButton";
            this.providerManagementButton.Size = new System.Drawing.Size(177, 34);
            this.providerManagementButton.Style = MetroFramework.MetroColorStyle.Green;
            this.providerManagementButton.TabIndex = 9;
            this.providerManagementButton.Text = "Prestadores de serviço";
            this.providerManagementButton.UseSelectable = true;
            this.providerManagementButton.UseStyleColors = true;
            this.providerManagementButton.Click += new System.EventHandler(this.ProviderManagementButton_Click);
            // 
            // monthlyTotalDisplay
            // 
            this.monthlyTotalDisplay.BackColor = System.Drawing.Color.White;
            this.monthlyTotalDisplay.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.monthlyTotalDisplay.Location = new System.Drawing.Point(610, 58);
            this.monthlyTotalDisplay.Name = "monthlyTotalDisplay";
            this.monthlyTotalDisplay.Size = new System.Drawing.Size(284, 28);
            this.monthlyTotalDisplay.TabIndex = 30;
            this.monthlyTotalDisplay.Text = "Total recebido: R$ 0,00";
            this.monthlyTotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePanel
            // 
            this.dateTimePanel.Location = new System.Drawing.Point(141, 513);
            this.dateTimePanel.Name = "dateTimePanel";
            this.dateTimePanel.Size = new System.Drawing.Size(637, 62);
            this.dateTimePanel.TabIndex = 31;
            this.dateTimePanel.Visible = false;
            // 
            // filterByDateSelector
            // 
            this.filterByDateSelector.AutoSize = true;
            this.filterByDateSelector.Location = new System.Drawing.Point(21, 540);
            this.filterByDateSelector.Name = "filterByDateSelector";
            this.filterByDateSelector.Size = new System.Drawing.Size(100, 15);
            this.filterByDateSelector.TabIndex = 32;
            this.filterByDateSelector.Text = "Filtrar por data";
            this.filterByDateSelector.UseSelectable = true;
            this.filterByDateSelector.CheckedChanged += new System.EventHandler(this.FilterByDateSelector_CheckedChanged);
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 587);
            this.Controls.Add(this.filterByDateSelector);
            this.Controls.Add(this.dateTimePanel);
            this.Controls.Add(this.monthlyTotalDisplay);
            this.Controls.Add(this.providerManagementButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.serviceGrid);
            this.MaximizeBox = false;
            this.Name = "ServiceManagement";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestão de Serviços";
            ((System.ComponentModel.ISupportInitialize)(this.serviceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid serviceGrid;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroButton addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private MetroFramework.Controls.MetroButton providerManagementButton;
        private System.Windows.Forms.Label monthlyTotalDisplay;
        private System.Windows.Forms.Panel dateTimePanel;
        private MetroFramework.Controls.MetroCheckBox filterByDateSelector;
    }
}