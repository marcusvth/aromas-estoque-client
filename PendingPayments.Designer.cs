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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pendingGrid = new MetroFramework.Controls.MetroGrid();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pendingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingGrid
            // 
            this.pendingGrid.AllowUserToAddRows = false;
            this.pendingGrid.AllowUserToDeleteRows = false;
            this.pendingGrid.AllowUserToResizeRows = false;
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
            this.SaleId,
            this.Customer,
            this.Total,
            this.PaidAmount,
            this.Pay});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.pendingGrid.EnableHeadersVisualStyles = false;
            this.pendingGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pendingGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pendingGrid.Location = new System.Drawing.Point(23, 63);
            this.pendingGrid.Name = "pendingGrid";
            this.pendingGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.pendingGrid.RowHeadersVisible = false;
            this.pendingGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pendingGrid.RowTemplate.Height = 40;
            this.pendingGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendingGrid.Size = new System.Drawing.Size(811, 409);
            this.pendingGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.pendingGrid.TabIndex = 8;
            this.pendingGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PendingGrid_CellMouseDown);
            // 
            // SaleId
            // 
            this.SaleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleId.DataPropertyName = "SaleId";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.SaleId.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaleId.HeaderText = "Venda";
            this.SaleId.Name = "SaleId";
            this.SaleId.Width = 72;
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
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Valor Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 93;
            // 
            // PaidAmount
            // 
            this.PaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaidAmount.DataPropertyName = "PaidAmount";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            this.PaidAmount.DefaultCellStyle = dataGridViewCellStyle5;
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
            // PendingPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 495);
            this.Controls.Add(this.pendingGrid);
            this.MaximizeBox = false;
            this.Name = "PendingPayments";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pagamentos pendentes";
            this.Activated += new System.EventHandler(this.PendingPayments_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pendingGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid pendingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewButtonColumn Pay;
    }
}