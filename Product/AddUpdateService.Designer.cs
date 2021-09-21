namespace AromasEstoque
{
    partial class AddUpdateService
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
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.priceInput = new MetroFramework.Controls.MetroTextBox();
            this.priceHeader = new MetroFramework.Controls.MetroLabel();
            this.descriptionInput = new MetroFramework.Controls.MetroTextBox();
            this.descriptionHeader = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Highlight = true;
            this.cancelButton.Location = new System.Drawing.Point(421, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Highlight = true;
            this.okButton.Location = new System.Drawing.Point(346, 130);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 18;
            this.okButton.Text = "Cadastrar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // priceInput
            // 
            // 
            // 
            // 
            this.priceInput.CustomButton.Image = null;
            this.priceInput.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.priceInput.CustomButton.Name = "";
            this.priceInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceInput.CustomButton.TabIndex = 1;
            this.priceInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceInput.CustomButton.UseSelectable = true;
            this.priceInput.CustomButton.Visible = false;
            this.priceInput.Lines = new string[] {
        "0,00"};
            this.priceInput.Location = new System.Drawing.Point(381, 87);
            this.priceInput.MaxLength = 150;
            this.priceInput.Name = "priceInput";
            this.priceInput.PasswordChar = '\0';
            this.priceInput.PromptText = "Valor do serviço";
            this.priceInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceInput.SelectedText = "";
            this.priceInput.SelectionLength = 0;
            this.priceInput.SelectionStart = 0;
            this.priceInput.ShortcutsEnabled = true;
            this.priceInput.Size = new System.Drawing.Size(109, 23);
            this.priceInput.Style = MetroFramework.MetroColorStyle.Green;
            this.priceInput.TabIndex = 15;
            this.priceInput.Text = "0,00";
            this.priceInput.UseSelectable = true;
            this.priceInput.UseStyleColors = true;
            this.priceInput.WaterMark = "Valor do serviço";
            this.priceInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.priceInput.TextChanged += new System.EventHandler(this.PriceInput_TextChanged);
            this.priceInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceInput_KeyDown);
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceInput_KeyPress);
            // 
            // priceHeader
            // 
            this.priceHeader.AutoSize = true;
            this.priceHeader.Location = new System.Drawing.Point(379, 65);
            this.priceHeader.Name = "priceHeader";
            this.priceHeader.Size = new System.Drawing.Size(38, 19);
            this.priceHeader.TabIndex = 14;
            this.priceHeader.Text = "Valor";
            // 
            // descriptionInput
            // 
            // 
            // 
            // 
            this.descriptionInput.CustomButton.Image = null;
            this.descriptionInput.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.descriptionInput.CustomButton.Name = "";
            this.descriptionInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionInput.CustomButton.TabIndex = 1;
            this.descriptionInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionInput.CustomButton.UseSelectable = true;
            this.descriptionInput.CustomButton.Visible = false;
            this.descriptionInput.Lines = new string[0];
            this.descriptionInput.Location = new System.Drawing.Point(28, 87);
            this.descriptionInput.MaxLength = 150;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PromptText = "Insira aqui o nome ou a descrição do serviço";
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.SelectionLength = 0;
            this.descriptionInput.SelectionStart = 0;
            this.descriptionInput.ShortcutsEnabled = true;
            this.descriptionInput.Size = new System.Drawing.Size(317, 23);
            this.descriptionInput.Style = MetroFramework.MetroColorStyle.Green;
            this.descriptionInput.TabIndex = 11;
            this.descriptionInput.UseSelectable = true;
            this.descriptionInput.UseStyleColors = true;
            this.descriptionInput.WaterMark = "Insira aqui o nome ou a descrição do serviço";
            this.descriptionInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionInput.TextChanged += new System.EventHandler(this.PriceInput_TextChanged);
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.AutoSize = true;
            this.descriptionHeader.Location = new System.Drawing.Point(24, 65);
            this.descriptionHeader.Name = "descriptionHeader";
            this.descriptionHeader.Size = new System.Drawing.Size(65, 19);
            this.descriptionHeader.TabIndex = 10;
            this.descriptionHeader.Text = "Descrição";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(351, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "R$";
            // 
            // AddUpdateService
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(532, 182);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceHeader);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.descriptionHeader);
            this.Name = "AddUpdateService";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cadastrando serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroTextBox priceInput;
        private MetroFramework.Controls.MetroLabel priceHeader;
        private MetroFramework.Controls.MetroTextBox descriptionInput;
        private MetroFramework.Controls.MetroLabel descriptionHeader;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}