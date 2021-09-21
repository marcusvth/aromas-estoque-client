namespace AromasEstoque
{
    partial class ImportXml
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loadFileButton = new MetroFramework.Controls.MetroButton();
            this.openXmlFile = new System.Windows.Forms.OpenFileDialog();
            this.productsGrid = new MetroFramework.Controls.MetroGrid();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importAllButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.gridHeader = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Highlight = true;
            this.loadFileButton.Location = new System.Drawing.Point(23, 63);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(135, 40);
            this.loadFileButton.Style = MetroFramework.MetroColorStyle.Green;
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Carregar um arquivo";
            this.loadFileButton.UseSelectable = true;
            this.loadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // openXmlFile
            // 
            this.openXmlFile.FileName = "openFileDialog1";
            this.openXmlFile.Title = "Selecione um arquivo XML para importar";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.AllowUserToResizeRows = false;
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGrid.ColumnHeadersHeight = 40;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Specification,
            this.InventoryAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsGrid.EnableHeadersVisualStyles = false;
            this.productsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGrid.Location = new System.Drawing.Point(23, 160);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsGrid.RowHeadersVisible = false;
            this.productsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGrid.RowTemplate.Height = 40;
            this.productsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGrid.Size = new System.Drawing.Size(883, 271);
            this.productsGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.productsGrid.TabIndex = 2;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Cód. Barras";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 127;
            // 
            // Specification
            // 
            this.Specification.DataPropertyName = "Specification";
            dataGridViewCellStyle2.NullValue = null;
            this.Specification.DefaultCellStyle = dataGridViewCellStyle2;
            this.Specification.HeaderText = "Produto";
            this.Specification.Name = "Specification";
            this.Specification.ReadOnly = true;
            // 
            // InventoryAmount
            // 
            this.InventoryAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryAmount.DataPropertyName = "InventoryAmount";
            this.InventoryAmount.HeaderText = "Quantidade";
            this.InventoryAmount.Name = "InventoryAmount";
            this.InventoryAmount.Width = 128;
            // 
            // importAllButton
            // 
            this.importAllButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.importAllButton.Highlight = true;
            this.importAllButton.Location = new System.Drawing.Point(630, 455);
            this.importAllButton.Name = "importAllButton";
            this.importAllButton.Size = new System.Drawing.Size(135, 40);
            this.importAllButton.Style = MetroFramework.MetroColorStyle.Green;
            this.importAllButton.TabIndex = 3;
            this.importAllButton.Text = "Importar todos";
            this.importAllButton.UseSelectable = true;
            this.importAllButton.Click += new System.EventHandler(this.ImportAllButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Highlight = true;
            this.cancelButton.Location = new System.Drawing.Point(771, 455);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 40);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // gridHeader
            // 
            this.gridHeader.AutoSize = true;
            this.gridHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.gridHeader.Location = new System.Drawing.Point(375, 128);
            this.gridHeader.Name = "gridHeader";
            this.gridHeader.Size = new System.Drawing.Size(169, 25);
            this.gridHeader.TabIndex = 5;
            this.gridHeader.Text = "Produtos carregados";
            // 
            // ImportXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 515);
            this.Controls.Add(this.gridHeader);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.importAllButton);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.loadFileButton);
            this.MaximizeBox = false;
            this.Name = "ImportXml";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Importação de XML";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton loadFileButton;
        private System.Windows.Forms.OpenFileDialog openXmlFile;
        private MetroFramework.Controls.MetroGrid productsGrid;
        private MetroFramework.Controls.MetroButton importAllButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel gridHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryAmount;
    }
}