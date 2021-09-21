namespace AromasEstoque
{
    partial class AddUpdateEmployee
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
            this.adminHeader = new MetroFramework.Controls.MetroLabel();
            this.passwordInput = new MetroFramework.Controls.MetroTextBox();
            this.passwordheader = new MetroFramework.Controls.MetroLabel();
            this.usernameInput = new MetroFramework.Controls.MetroTextBox();
            this.usernameHeader = new MetroFramework.Controls.MetroLabel();
            this.nameInput = new MetroFramework.Controls.MetroTextBox();
            this.nameHeader = new MetroFramework.Controls.MetroLabel();
            this.adminToggle = new MetroFramework.Controls.MetroToggle();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Highlight = true;
            this.cancelButton.Location = new System.Drawing.Point(392, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Highlight = true;
            this.okButton.Location = new System.Drawing.Point(317, 203);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 18;
            this.okButton.Text = "Cadastrar";
            this.okButton.UseSelectable = true;
            this.okButton.UseStyleColors = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // adminHeader
            // 
            this.adminHeader.AutoSize = true;
            this.adminHeader.Location = new System.Drawing.Point(302, 122);
            this.adminHeader.Name = "adminHeader";
            this.adminHeader.Size = new System.Drawing.Size(159, 19);
            this.adminHeader.Style = MetroFramework.MetroColorStyle.Green;
            this.adminHeader.TabIndex = 16;
            this.adminHeader.Text = "Privilégios administrativos";
            // 
            // passwordInput
            // 
            // 
            // 
            // 
            this.passwordInput.CustomButton.Image = null;
            this.passwordInput.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.passwordInput.CustomButton.Name = "";
            this.passwordInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordInput.CustomButton.TabIndex = 1;
            this.passwordInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordInput.CustomButton.UseSelectable = true;
            this.passwordInput.CustomButton.Visible = false;
            this.passwordInput.Lines = new string[0];
            this.passwordInput.Location = new System.Drawing.Point(168, 144);
            this.passwordInput.MaxLength = 150;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.PromptText = "Senha";
            this.passwordInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(109, 23);
            this.passwordInput.Style = MetroFramework.MetroColorStyle.Green;
            this.passwordInput.TabIndex = 15;
            this.passwordInput.UseSelectable = true;
            this.passwordInput.UseStyleColors = true;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.WaterMark = "Senha";
            this.passwordInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordInput.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // passwordheader
            // 
            this.passwordheader.AutoSize = true;
            this.passwordheader.Location = new System.Drawing.Point(164, 122);
            this.passwordheader.Name = "passwordheader";
            this.passwordheader.Size = new System.Drawing.Size(44, 19);
            this.passwordheader.Style = MetroFramework.MetroColorStyle.Green;
            this.passwordheader.TabIndex = 14;
            this.passwordheader.Text = "Senha";
            // 
            // usernameInput
            // 
            // 
            // 
            // 
            this.usernameInput.CustomButton.Image = null;
            this.usernameInput.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.usernameInput.CustomButton.Name = "";
            this.usernameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameInput.CustomButton.TabIndex = 1;
            this.usernameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameInput.CustomButton.UseSelectable = true;
            this.usernameInput.CustomButton.Visible = false;
            this.usernameInput.Lines = new string[0];
            this.usernameInput.Location = new System.Drawing.Point(27, 144);
            this.usernameInput.MaxLength = 13;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PromptText = "Usuário";
            this.usernameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameInput.SelectedText = "";
            this.usernameInput.SelectionLength = 0;
            this.usernameInput.SelectionStart = 0;
            this.usernameInput.ShortcutsEnabled = true;
            this.usernameInput.Size = new System.Drawing.Size(109, 23);
            this.usernameInput.Style = MetroFramework.MetroColorStyle.Green;
            this.usernameInput.TabIndex = 13;
            this.usernameInput.UseSelectable = true;
            this.usernameInput.UseStyleColors = true;
            this.usernameInput.WaterMark = "Usuário";
            this.usernameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usernameInput.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // usernameHeader
            // 
            this.usernameHeader.AutoSize = true;
            this.usernameHeader.Location = new System.Drawing.Point(23, 122);
            this.usernameHeader.Name = "usernameHeader";
            this.usernameHeader.Size = new System.Drawing.Size(53, 19);
            this.usernameHeader.Style = MetroFramework.MetroColorStyle.Green;
            this.usernameHeader.TabIndex = 12;
            this.usernameHeader.Text = "Usuário";
            // 
            // nameInput
            // 
            // 
            // 
            // 
            this.nameInput.CustomButton.Image = null;
            this.nameInput.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.nameInput.CustomButton.Name = "";
            this.nameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameInput.CustomButton.TabIndex = 1;
            this.nameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameInput.CustomButton.UseSelectable = true;
            this.nameInput.CustomButton.Visible = false;
            this.nameInput.Lines = new string[0];
            this.nameInput.Location = new System.Drawing.Point(27, 83);
            this.nameInput.MaxLength = 150;
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PromptText = "Insira aqui o nome completo do funcionário";
            this.nameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameInput.SelectedText = "";
            this.nameInput.SelectionLength = 0;
            this.nameInput.SelectionStart = 0;
            this.nameInput.ShortcutsEnabled = true;
            this.nameInput.Size = new System.Drawing.Size(434, 23);
            this.nameInput.Style = MetroFramework.MetroColorStyle.Green;
            this.nameInput.TabIndex = 11;
            this.nameInput.UseSelectable = true;
            this.nameInput.UseStyleColors = true;
            this.nameInput.WaterMark = "Insira aqui o nome completo do funcionário";
            this.nameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameInput.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Location = new System.Drawing.Point(23, 61);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(106, 19);
            this.nameHeader.Style = MetroFramework.MetroColorStyle.Green;
            this.nameHeader.TabIndex = 10;
            this.nameHeader.Text = "Nome completo";
            // 
            // adminToggle
            // 
            this.adminToggle.AutoSize = true;
            this.adminToggle.DisplayStatus = false;
            this.adminToggle.Location = new System.Drawing.Point(306, 150);
            this.adminToggle.Name = "adminToggle";
            this.adminToggle.Size = new System.Drawing.Size(50, 17);
            this.adminToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.adminToggle.TabIndex = 20;
            this.adminToggle.Text = "Off";
            this.adminToggle.UseSelectable = true;
            // 
            // AddUpdateEmployee
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(492, 256);
            this.Controls.Add(this.adminToggle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.adminHeader);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordheader);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameHeader);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameHeader);
            this.MaximizeBox = false;
            this.Name = "AddUpdateEmployee";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cadastrando funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroLabel adminHeader;
        private MetroFramework.Controls.MetroTextBox passwordInput;
        private MetroFramework.Controls.MetroLabel passwordheader;
        private MetroFramework.Controls.MetroTextBox usernameInput;
        private MetroFramework.Controls.MetroLabel usernameHeader;
        private MetroFramework.Controls.MetroTextBox nameInput;
        private MetroFramework.Controls.MetroLabel nameHeader;
        private MetroFramework.Controls.MetroToggle adminToggle;
    }
}