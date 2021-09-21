namespace AromasEstoque
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.productsGrid = new MetroFramework.Controls.MetroGrid();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchInput = new MetroFramework.Controls.MetroTextBox();
            this.importXmlButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.ProductId,
            this.Barcode,
            this.Specification,
            this.SalePrice,
            this.InventoryAmount,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.productsGrid.EnableHeadersVisualStyles = false;
            this.productsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGrid.Location = new System.Drawing.Point(21, 109);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productsGrid.RowHeadersVisible = false;
            this.productsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGrid.RowTemplate.Height = 40;
            this.productsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGrid.Size = new System.Drawing.Size(1040, 438);
            this.productsGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.productsGrid.TabIndex = 0;
            this.productsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductsGrid_CellFormatting);
            this.productsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsGrid_CellMouseDown);
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Nº";
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 69;
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
            // SalePrice
            // 
            this.SalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalePrice.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalePrice.HeaderText = "Preço de Venda";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Width = 152;
            // 
            // InventoryAmount
            // 
            this.InventoryAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryAmount.DataPropertyName = "InventoryAmount";
            this.InventoryAmount.HeaderText = "Qtd. Estoque";
            this.InventoryAmount.Name = "InventoryAmount";
            this.InventoryAmount.ReadOnly = true;
            this.InventoryAmount.Width = 136;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 37;
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
            // searchInput
            // 
            // 
            // 
            // 
            this.searchInput.CustomButton.Image = null;
            this.searchInput.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.searchInput.CustomButton.Name = "";
            this.searchInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchInput.CustomButton.TabIndex = 1;
            this.searchInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchInput.CustomButton.UseSelectable = true;
            this.searchInput.CustomButton.Visible = false;
            this.searchInput.Lines = new string[0];
            this.searchInput.Location = new System.Drawing.Point(369, 81);
            this.searchInput.MaxLength = 32767;
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PromptText = "Insira o nome ou código de barras do produto e aperte enter";
            this.searchInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchInput.SelectedText = "";
            this.searchInput.SelectionLength = 0;
            this.searchInput.SelectionStart = 0;
            this.searchInput.ShortcutsEnabled = true;
            this.searchInput.Size = new System.Drawing.Size(339, 23);
            this.searchInput.Style = MetroFramework.MetroColorStyle.Green;
            this.searchInput.TabIndex = 4;
            this.searchInput.UseSelectable = true;
            this.searchInput.UseStyleColors = true;
            this.searchInput.WaterMark = "Insira o nome ou código de barras do produto e aperte enter";
            this.searchInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyDown);
            // 
            // importXmlButton
            // 
            this.importXmlButton.Highlight = true;
            this.importXmlButton.Location = new System.Drawing.Point(934, 82);
            this.importXmlButton.Name = "importXmlButton";
            this.importXmlButton.Size = new System.Drawing.Size(124, 22);
            this.importXmlButton.Style = MetroFramework.MetroColorStyle.Green;
            this.importXmlButton.TabIndex = 3;
            this.importXmlButton.Text = "Importar de XML";
            this.importXmlButton.UseSelectable = true;
            this.importXmlButton.UseStyleColors = true;
            this.importXmlButton.Click += new System.EventHandler(this.ImportXmlButton_Click);
            // 
            // addButton
            // 
            this.addButton.Highlight = true;
            this.addButton.Location = new System.Drawing.Point(21, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 22);
            this.addButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Cadastrar produto";
            this.addButton.UseSelectable = true;
            this.addButton.UseStyleColors = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AromasEstoque.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 603);
            this.Controls.Add(this.importXmlButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.addButton);
            this.Name = "ProductManagement";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestão de produtos";
            this.Activated += new System.EventHandler(this.ProductManagement_Activated);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid productsGrid;
        private MetroFramework.Controls.MetroTextBox searchInput;
        private MetroFramework.Controls.MetroButton importXmlButton;
        private MetroFramework.Controls.MetroButton addButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryAmount;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}