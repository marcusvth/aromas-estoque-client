namespace AromasEstoque
{
    partial class FromToDatetime
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
            this.toDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.toDateHeader = new MetroFramework.Controls.MetroLabel();
            this.fromDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.fromDateHeader = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toDatePicker.Location = new System.Drawing.Point(362, 17);
            this.toDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(224, 29);
            this.toDatePicker.Style = MetroFramework.MetroColorStyle.Green;
            this.toDatePicker.TabIndex = 10;
            // 
            // toDateHeader
            // 
            this.toDateHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.toDateHeader.AutoSize = true;
            this.toDateHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.toDateHeader.Location = new System.Drawing.Point(314, 21);
            this.toDateHeader.Name = "toDateHeader";
            this.toDateHeader.Size = new System.Drawing.Size(28, 19);
            this.toDateHeader.TabIndex = 9;
            this.toDateHeader.Text = "até";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDatePicker.Location = new System.Drawing.Point(60, 17);
            this.fromDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(241, 29);
            this.fromDatePicker.Style = MetroFramework.MetroColorStyle.Green;
            this.fromDatePicker.TabIndex = 8;
            this.fromDatePicker.UseStyleColors = true;
            // 
            // fromDateHeader
            // 
            this.fromDateHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fromDateHeader.AutoSize = true;
            this.fromDateHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.fromDateHeader.Location = new System.Drawing.Point(28, 21);
            this.fromDateHeader.Name = "fromDateHeader";
            this.fromDateHeader.Size = new System.Drawing.Size(24, 19);
            this.fromDateHeader.TabIndex = 7;
            this.fromDateHeader.Text = "de";
            // 
            // FromToDatetime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.toDateHeader);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.fromDateHeader);
            this.Name = "FromToDatetime";
            this.Size = new System.Drawing.Size(637, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime toDatePicker;
        private MetroFramework.Controls.MetroLabel toDateHeader;
        private MetroFramework.Controls.MetroDateTime fromDatePicker;
        private MetroFramework.Controls.MetroLabel fromDateHeader;
    }
}
