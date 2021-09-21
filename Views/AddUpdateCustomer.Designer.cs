namespace AromasEstoque
{
    partial class AddUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateCustomer));
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.phoneInput = new MetroFramework.Controls.MetroTextBox();
            this.phoneHeader = new MetroFramework.Controls.MetroLabel();
            this.nameInput = new MetroFramework.Controls.MetroTextBox();
            this.nameHeader = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Highlight = true;
            this.cancelButton.Location = new System.Drawing.Point(354, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 25;
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
            this.okButton.Location = new System.Drawing.Point(278, 131);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 24;
            this.okButton.Text = "Cadastrar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // phoneInput
            // 
            // 
            // 
            // 
            this.phoneInput.CustomButton.Image = null;
            this.phoneInput.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.phoneInput.CustomButton.Name = "";
            this.phoneInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneInput.CustomButton.TabIndex = 1;
            this.phoneInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneInput.CustomButton.UseSelectable = true;
            this.phoneInput.CustomButton.Visible = false;
            this.phoneInput.Lines = new string[0];
            this.phoneInput.Location = new System.Drawing.Point(278, 80);
            this.phoneInput.MaxLength = 150;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.PasswordChar = '\0';
            this.phoneInput.PromptText = "Telefone";
            this.phoneInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneInput.SelectedText = "";
            this.phoneInput.SelectionLength = 0;
            this.phoneInput.SelectionStart = 0;
            this.phoneInput.ShortcutsEnabled = true;
            this.phoneInput.Size = new System.Drawing.Size(145, 23);
            this.phoneInput.Style = MetroFramework.MetroColorStyle.Green;
            this.phoneInput.TabIndex = 23;
            this.phoneInput.UseSelectable = true;
            this.phoneInput.UseStyleColors = true;
            this.phoneInput.WaterMark = "Telefone";
            this.phoneInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phoneHeader
            // 
            this.phoneHeader.AutoSize = true;
            this.phoneHeader.Location = new System.Drawing.Point(278, 58);
            this.phoneHeader.Name = "phoneHeader";
            this.phoneHeader.Size = new System.Drawing.Size(57, 19);
            this.phoneHeader.TabIndex = 22;
            this.phoneHeader.Text = "Telefone";
            // 
            // nameInput
            // 
            // 
            // 
            // 
            this.nameInput.CustomButton.Image = null;
            this.nameInput.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.nameInput.CustomButton.Name = "";
            this.nameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameInput.CustomButton.TabIndex = 1;
            this.nameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameInput.CustomButton.UseSelectable = true;
            this.nameInput.CustomButton.Visible = false;
            this.nameInput.Lines = new string[0];
            this.nameInput.Location = new System.Drawing.Point(27, 80);
            this.nameInput.MaxLength = 150;
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PromptText = "Insira aqui o nome do cliente";
            this.nameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameInput.SelectedText = "";
            this.nameInput.SelectionLength = 0;
            this.nameInput.SelectionStart = 0;
            this.nameInput.ShortcutsEnabled = true;
            this.nameInput.Size = new System.Drawing.Size(245, 23);
            this.nameInput.Style = MetroFramework.MetroColorStyle.Green;
            this.nameInput.TabIndex = 21;
            this.nameInput.UseSelectable = true;
            this.nameInput.UseStyleColors = true;
            this.nameInput.WaterMark = "Insira aqui o nome do cliente";
            this.nameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Location = new System.Drawing.Point(23, 58);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(46, 19);
            this.nameHeader.TabIndex = 20;
            this.nameHeader.Text = "Nome";
            // 
            // AddUpdateCustomer
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(450, 182);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.phoneHeader);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUpdateCustomer";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cadastrando cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroTextBox phoneInput;
        private MetroFramework.Controls.MetroLabel phoneHeader;
        private MetroFramework.Controls.MetroTextBox nameInput;
        private MetroFramework.Controls.MetroLabel nameHeader;
    }
}