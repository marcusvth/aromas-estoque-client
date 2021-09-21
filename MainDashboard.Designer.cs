namespace AromasEstoque
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.productsButton = new MetroFramework.Controls.MetroTile();
            this.servicesButton = new MetroFramework.Controls.MetroTile();
            this.employeesButton = new MetroFramework.Controls.MetroTile();
            this.transactionsButton = new MetroFramework.Controls.MetroTile();
            this.salesButton = new MetroFramework.Controls.MetroTile();
            this.customersButton = new MetroFramework.Controls.MetroTile();
            this.welcomeMessage = new MetroFramework.Controls.MetroLabel();
            this.pendingPaymentsButton = new MetroFramework.Controls.MetroTile();
            this.salePoint = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // productsButton
            // 
            this.productsButton.ActiveControl = null;
            this.productsButton.Location = new System.Drawing.Point(53, 125);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(224, 144);
            this.productsButton.Style = MetroFramework.MetroColorStyle.Green;
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Produtos";
            this.productsButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productsButton.TileImage = ((System.Drawing.Image)(resources.GetObject("productsButton.TileImage")));
            this.productsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productsButton.UseSelectable = true;
            this.productsButton.UseTileImage = true;
            this.productsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.ActiveControl = null;
            this.servicesButton.Location = new System.Drawing.Point(281, 125);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(224, 144);
            this.servicesButton.Style = MetroFramework.MetroColorStyle.Green;
            this.servicesButton.TabIndex = 1;
            this.servicesButton.Text = "Serviços";
            this.servicesButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.servicesButton.TileImage = ((System.Drawing.Image)(resources.GetObject("servicesButton.TileImage")));
            this.servicesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.servicesButton.UseSelectable = true;
            this.servicesButton.UseTileImage = true;
            this.servicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.ActiveControl = null;
            this.employeesButton.Location = new System.Drawing.Point(509, 125);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(224, 144);
            this.employeesButton.Style = MetroFramework.MetroColorStyle.Green;
            this.employeesButton.TabIndex = 2;
            this.employeesButton.Text = "Funcionários";
            this.employeesButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeesButton.TileImage = ((System.Drawing.Image)(resources.GetObject("employeesButton.TileImage")));
            this.employeesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeesButton.UseSelectable = true;
            this.employeesButton.UseTileImage = true;
            this.employeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // transactionsButton
            // 
            this.transactionsButton.ActiveControl = null;
            this.transactionsButton.Location = new System.Drawing.Point(53, 273);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(224, 144);
            this.transactionsButton.Style = MetroFramework.MetroColorStyle.Green;
            this.transactionsButton.TabIndex = 3;
            this.transactionsButton.Text = "Movimentação financeira";
            this.transactionsButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.transactionsButton.TileImage = ((System.Drawing.Image)(resources.GetObject("transactionsButton.TileImage")));
            this.transactionsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transactionsButton.UseSelectable = true;
            this.transactionsButton.UseTileImage = true;
            this.transactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.ActiveControl = null;
            this.salesButton.Location = new System.Drawing.Point(281, 273);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(224, 144);
            this.salesButton.Style = MetroFramework.MetroColorStyle.Green;
            this.salesButton.TabIndex = 4;
            this.salesButton.Text = "Vendas";
            this.salesButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salesButton.TileImage = ((System.Drawing.Image)(resources.GetObject("salesButton.TileImage")));
            this.salesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salesButton.UseSelectable = true;
            this.salesButton.UseTileImage = true;
            this.salesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.ActiveControl = null;
            this.customersButton.Location = new System.Drawing.Point(509, 273);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(224, 144);
            this.customersButton.Style = MetroFramework.MetroColorStyle.Green;
            this.customersButton.TabIndex = 5;
            this.customersButton.Text = "Clientes";
            this.customersButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customersButton.TileImage = ((System.Drawing.Image)(resources.GetObject("customersButton.TileImage")));
            this.customersButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customersButton.UseSelectable = true;
            this.customersButton.UseTileImage = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeMessage.Location = new System.Drawing.Point(2, 66);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(1011, 25);
            this.welcomeMessage.TabIndex = 6;
            this.welcomeMessage.Text = "Bem vindo(a), Eliane!";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pendingPaymentsButton
            // 
            this.pendingPaymentsButton.ActiveControl = null;
            this.pendingPaymentsButton.Location = new System.Drawing.Point(737, 125);
            this.pendingPaymentsButton.Name = "pendingPaymentsButton";
            this.pendingPaymentsButton.Size = new System.Drawing.Size(224, 144);
            this.pendingPaymentsButton.Style = MetroFramework.MetroColorStyle.Green;
            this.pendingPaymentsButton.TabIndex = 8;
            this.pendingPaymentsButton.Text = "Pagamentos pendentes";
            this.pendingPaymentsButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pendingPaymentsButton.TileImage = ((System.Drawing.Image)(resources.GetObject("pendingPaymentsButton.TileImage")));
            this.pendingPaymentsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pendingPaymentsButton.UseSelectable = true;
            this.pendingPaymentsButton.UseTileImage = true;
            this.pendingPaymentsButton.Click += new System.EventHandler(this.PendingPaymentsButton_Click);
            // 
            // salePoint
            // 
            this.salePoint.ActiveControl = null;
            this.salePoint.Location = new System.Drawing.Point(737, 273);
            this.salePoint.Name = "salePoint";
            this.salePoint.Size = new System.Drawing.Size(224, 144);
            this.salePoint.Style = MetroFramework.MetroColorStyle.Green;
            this.salePoint.TabIndex = 9;
            this.salePoint.Text = "Iniciar ponto de vendas";
            this.salePoint.TileImage = ((System.Drawing.Image)(resources.GetObject("salePoint.TileImage")));
            this.salePoint.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salePoint.UseSelectable = true;
            this.salePoint.UseTileImage = true;
            this.salePoint.Click += new System.EventHandler(this.StartPointOfSaleButton_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 541);
            this.Controls.Add(this.salePoint);
            this.Controls.Add(this.pendingPaymentsButton);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.transactionsButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.productsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainDashboard";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Aromas - Perfumes e Cosméticos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile productsButton;
        private MetroFramework.Controls.MetroTile servicesButton;
        private MetroFramework.Controls.MetroTile employeesButton;
        private MetroFramework.Controls.MetroTile transactionsButton;
        private MetroFramework.Controls.MetroTile salesButton;
        private MetroFramework.Controls.MetroTile customersButton;
        private MetroFramework.Controls.MetroLabel welcomeMessage;
        private MetroFramework.Controls.MetroTile pendingPaymentsButton;
        private MetroFramework.Controls.MetroTile salePoint;
    }
}