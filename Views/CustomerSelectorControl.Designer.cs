namespace AromasEstoque
{
    partial class CustomerSelectorControl
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
            this.notIdenfityCustomerCheck = new MetroFramework.Controls.MetroCheckBox();
            this.customerOnlyPanel = new System.Windows.Forms.Panel();
            this.addCustomerButton = new MetroFramework.Controls.MetroButton();
            this.customerHeader = new MetroFramework.Controls.MetroLabel();
            this.customerSelector = new MetroFramework.Controls.MetroComboBox();
            this.customerOnlyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notIdenfityCustomerCheck
            // 
            this.notIdenfityCustomerCheck.AutoSize = true;
            this.notIdenfityCustomerCheck.Checked = true;
            this.notIdenfityCustomerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notIdenfityCustomerCheck.Location = new System.Drawing.Point(288, 78);
            this.notIdenfityCustomerCheck.Name = "notIdenfityCustomerCheck";
            this.notIdenfityCustomerCheck.Size = new System.Drawing.Size(139, 15);
            this.notIdenfityCustomerCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.notIdenfityCustomerCheck.TabIndex = 22;
            this.notIdenfityCustomerCheck.Text = "Não identificar cliente";
            this.notIdenfityCustomerCheck.UseSelectable = true;
            this.notIdenfityCustomerCheck.CheckedChanged += new System.EventHandler(this.NotIdenfityCustomerCheck_CheckedChanged);
            // 
            // customerOnlyPanel
            // 
            this.customerOnlyPanel.BackColor = System.Drawing.Color.White;
            this.customerOnlyPanel.Controls.Add(this.addCustomerButton);
            this.customerOnlyPanel.Controls.Add(this.customerHeader);
            this.customerOnlyPanel.Controls.Add(this.customerSelector);
            this.customerOnlyPanel.Location = new System.Drawing.Point(16, 0);
            this.customerOnlyPanel.Name = "customerOnlyPanel";
            this.customerOnlyPanel.Size = new System.Drawing.Size(682, 73);
            this.customerOnlyPanel.TabIndex = 23;
            this.customerOnlyPanel.Visible = false;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(527, 38);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(120, 29);
            this.addCustomerButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.Text = "Cadastrar cliente";
            this.addCustomerButton.UseSelectable = true;
            this.addCustomerButton.UseStyleColors = true;
            this.addCustomerButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // customerHeader
            // 
            this.customerHeader.AutoSize = true;
            this.customerHeader.Location = new System.Drawing.Point(255, 13);
            this.customerHeader.Name = "customerHeader";
            this.customerHeader.Size = new System.Drawing.Size(172, 19);
            this.customerHeader.TabIndex = 6;
            this.customerHeader.Text = "Selecione um cliente na lista";
            // 
            // customerSelector
            // 
            this.customerSelector.FormattingEnabled = true;
            this.customerSelector.ItemHeight = 23;
            this.customerSelector.Location = new System.Drawing.Point(36, 38);
            this.customerSelector.Name = "customerSelector";
            this.customerSelector.Size = new System.Drawing.Size(485, 29);
            this.customerSelector.Style = MetroFramework.MetroColorStyle.Green;
            this.customerSelector.TabIndex = 5;
            this.customerSelector.UseSelectable = true;
            this.customerSelector.SelectedIndexChanged += new System.EventHandler(this.CustomerSelector_SelectedIndexChanged);
            // 
            // CustomerSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.notIdenfityCustomerCheck);
            this.Controls.Add(this.customerOnlyPanel);
            this.Name = "CustomerSelectorControl";
            this.Size = new System.Drawing.Size(715, 105);
            this.customerOnlyPanel.ResumeLayout(false);
            this.customerOnlyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox notIdenfityCustomerCheck;
        private System.Windows.Forms.Panel customerOnlyPanel;
        private MetroFramework.Controls.MetroButton addCustomerButton;
        private MetroFramework.Controls.MetroLabel customerHeader;
        private MetroFramework.Controls.MetroComboBox customerSelector;
    }
}
