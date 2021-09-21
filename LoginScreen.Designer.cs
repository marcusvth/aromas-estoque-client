namespace AromasEstoque
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.passwordInput = new MetroFramework.Controls.MetroTextBox();
            this.usernameInput = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.badPwdMessage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            // 
            // 
            // 
            this.passwordInput.CustomButton.Image = null;
            this.passwordInput.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.passwordInput.CustomButton.Name = "";
            this.passwordInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordInput.CustomButton.TabIndex = 1;
            this.passwordInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordInput.CustomButton.UseSelectable = true;
            this.passwordInput.CustomButton.Visible = false;
            this.passwordInput.Lines = new string[0];
            this.passwordInput.Location = new System.Drawing.Point(105, 140);
            this.passwordInput.MaxLength = 150;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.PromptText = "Senha";
            this.passwordInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(200, 23);
            this.passwordInput.Style = MetroFramework.MetroColorStyle.Green;
            this.passwordInput.TabIndex = 19;
            this.passwordInput.UseSelectable = true;
            this.passwordInput.UseStyleColors = true;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.WaterMark = "Senha";
            this.passwordInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernameInput
            // 
            // 
            // 
            // 
            this.usernameInput.CustomButton.Image = null;
            this.usernameInput.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.usernameInput.CustomButton.Name = "";
            this.usernameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameInput.CustomButton.TabIndex = 1;
            this.usernameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameInput.CustomButton.UseSelectable = true;
            this.usernameInput.CustomButton.Visible = false;
            this.usernameInput.Lines = new string[0];
            this.usernameInput.Location = new System.Drawing.Point(105, 111);
            this.usernameInput.MaxLength = 13;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PromptText = "Usuário";
            this.usernameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameInput.SelectedText = "";
            this.usernameInput.SelectionLength = 0;
            this.usernameInput.SelectionStart = 0;
            this.usernameInput.ShortcutsEnabled = true;
            this.usernameInput.Size = new System.Drawing.Size(200, 23);
            this.usernameInput.Style = MetroFramework.MetroColorStyle.Green;
            this.usernameInput.TabIndex = 0;
            this.usernameInput.UseSelectable = true;
            this.usernameInput.UseStyleColors = true;
            this.usernameInput.WaterMark = "Usuário";
            this.usernameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginButton
            // 
            this.loginButton.Highlight = true;
            this.loginButton.Location = new System.Drawing.Point(151, 173);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 33);
            this.loginButton.Style = MetroFramework.MetroColorStyle.Green;
            this.loginButton.TabIndex = 20;
            this.loginButton.Text = "Entrar";
            this.loginButton.UseSelectable = true;
            this.loginButton.UseStyleColors = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // badPwdMessage
            // 
            this.badPwdMessage.AutoSize = true;
            this.badPwdMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.badPwdMessage.Location = new System.Drawing.Point(67, 214);
            this.badPwdMessage.Name = "badPwdMessage";
            this.badPwdMessage.Size = new System.Drawing.Size(277, 19);
            this.badPwdMessage.TabIndex = 21;
            this.badPwdMessage.Text = "Usuário ou senha incorretos. Tente novamente";
            this.badPwdMessage.UseCustomForeColor = true;
            this.badPwdMessage.Visible = false;
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 300);
            this.Controls.Add(this.badPwdMessage);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Aromas - Login";
            this.Shown += new System.EventHandler(this.LoginScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox passwordInput;
        private MetroFramework.Controls.MetroTextBox usernameInput;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLabel badPwdMessage;
    }
}