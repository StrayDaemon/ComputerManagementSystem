namespace ComputerManagementSYS_UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login = new ReaLTaiizor.Forms.ForeverForm();
            this.btnSignup = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.lblShwPass_LOGIN = new ReaLTaiizor.Controls.ForeverLabel();
            this.swtch_showpass_LOGIN = new ReaLTaiizor.Controls.ForeverToggle();
            this.lblPass_LOGIN = new ReaLTaiizor.Controls.ForeverLabel();
            this.lblUser_LOGIN = new ReaLTaiizor.Controls.ForeverLabel();
            this.btnLogin = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.txb_Password_LOGIN = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txb_Username_LOGIN = new ReaLTaiizor.Controls.ForeverTextBox();
            this.statbar = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Login.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Login.Controls.Add(this.btnSignup);
            this.Login.Controls.Add(this.lblShwPass_LOGIN);
            this.Login.Controls.Add(this.swtch_showpass_LOGIN);
            this.Login.Controls.Add(this.lblPass_LOGIN);
            this.Login.Controls.Add(this.lblUser_LOGIN);
            this.Login.Controls.Add(this.btnLogin);
            this.Login.Controls.Add(this.txb_Password_LOGIN);
            this.Login.Controls.Add(this.txb_Username_LOGIN);
            this.Login.Controls.Add(this.statbar);
            this.Login.Controls.Add(this.foreverClose1);
            this.Login.Controls.Add(this.foreverMinimize1);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Login.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Login.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Login.HeaderMaximize = false;
            this.Login.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.Login.Image = null;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.MinimumSize = new System.Drawing.Size(210, 50);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.Login.Sizable = false;
            this.Login.Size = new System.Drawing.Size(736, 450);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login  |  Computer Management System";
            this.Login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Login.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSignup.Location = new System.Drawing.Point(207, 344);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Rounded = true;
            this.btnSignup.Size = new System.Drawing.Size(160, 40);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "SIGN UP";
            this.btnSignup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblShwPass_LOGIN
            // 
            this.lblShwPass_LOGIN.AutoSize = true;
            this.lblShwPass_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.lblShwPass_LOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShwPass_LOGIN.ForeColor = System.Drawing.Color.LightGray;
            this.lblShwPass_LOGIN.Location = new System.Drawing.Point(311, 289);
            this.lblShwPass_LOGIN.Name = "lblShwPass_LOGIN";
            this.lblShwPass_LOGIN.Size = new System.Drawing.Size(152, 28);
            this.lblShwPass_LOGIN.TabIndex = 10;
            this.lblShwPass_LOGIN.Text = "Show password:";
            // 
            // swtch_showpass_LOGIN
            // 
            this.swtch_showpass_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.swtch_showpass_LOGIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.swtch_showpass_LOGIN.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.swtch_showpass_LOGIN.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.swtch_showpass_LOGIN.Checked = false;
            this.swtch_showpass_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swtch_showpass_LOGIN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.swtch_showpass_LOGIN.Location = new System.Drawing.Point(491, 283);
            this.swtch_showpass_LOGIN.Name = "swtch_showpass_LOGIN";
            this.swtch_showpass_LOGIN.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.swtch_showpass_LOGIN.Size = new System.Drawing.Size(76, 33);
            this.swtch_showpass_LOGIN.TabIndex = 9;
            this.swtch_showpass_LOGIN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.swtch_showpass_LOGIN.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.swtch_showpass_LOGIN.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.swtch_showpass_LOGIN_CheckedChanged);
            // 
            // lblPass_LOGIN
            // 
            this.lblPass_LOGIN.AutoSize = true;
            this.lblPass_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.lblPass_LOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass_LOGIN.ForeColor = System.Drawing.Color.LightGray;
            this.lblPass_LOGIN.Location = new System.Drawing.Point(62, 230);
            this.lblPass_LOGIN.Name = "lblPass_LOGIN";
            this.lblPass_LOGIN.Size = new System.Drawing.Size(97, 28);
            this.lblPass_LOGIN.TabIndex = 8;
            this.lblPass_LOGIN.Text = "Password:";
            // 
            // lblUser_LOGIN
            // 
            this.lblUser_LOGIN.AutoSize = true;
            this.lblUser_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.lblUser_LOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_LOGIN.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser_LOGIN.Location = new System.Drawing.Point(62, 151);
            this.lblUser_LOGIN.Name = "lblUser_LOGIN";
            this.lblUser_LOGIN.Size = new System.Drawing.Size(103, 28);
            this.lblUser_LOGIN.TabIndex = 7;
            this.lblUser_LOGIN.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.Location = new System.Drawing.Point(407, 344);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Rounded = true;
            this.btnLogin.Size = new System.Drawing.Size(160, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txb_Password_LOGIN
            // 
            this.txb_Password_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.txb_Password_LOGIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Password_LOGIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Password_LOGIN.FocusOnHover = false;
            this.txb_Password_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Password_LOGIN.Location = new System.Drawing.Point(183, 230);
            this.txb_Password_LOGIN.MaxLength = 32767;
            this.txb_Password_LOGIN.Multiline = false;
            this.txb_Password_LOGIN.Name = "txb_Password_LOGIN";
            this.txb_Password_LOGIN.ReadOnly = false;
            this.txb_Password_LOGIN.Size = new System.Drawing.Size(416, 34);
            this.txb_Password_LOGIN.TabIndex = 5;
            this.txb_Password_LOGIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Password_LOGIN.UseSystemPasswordChar = false;
            // 
            // txb_Username_LOGIN
            // 
            this.txb_Username_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.txb_Username_LOGIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Username_LOGIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Username_LOGIN.FocusOnHover = false;
            this.txb_Username_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Username_LOGIN.Location = new System.Drawing.Point(183, 151);
            this.txb_Username_LOGIN.MaxLength = 32767;
            this.txb_Username_LOGIN.Multiline = false;
            this.txb_Username_LOGIN.Name = "txb_Username_LOGIN";
            this.txb_Username_LOGIN.ReadOnly = false;
            this.txb_Username_LOGIN.Size = new System.Drawing.Size(416, 34);
            this.txb_Username_LOGIN.TabIndex = 4;
            this.txb_Username_LOGIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Username_LOGIN.UseSystemPasswordChar = false;
            // 
            // statbar
            // 
            this.statbar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.statbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statbar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statbar.ForeColor = System.Drawing.Color.White;
            this.statbar.Location = new System.Drawing.Point(1, 426);
            this.statbar.Name = "statbar";
            this.statbar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.statbar.ShowTimeDate = false;
            this.statbar.Size = new System.Drawing.Size(734, 23);
            this.statbar.TabIndex = 3;
            this.statbar.Text = "patualnathan@gmail.com";
            this.statbar.TextColor = System.Drawing.Color.White;
            this.statbar.TimeColor = System.Drawing.Color.White;
            this.statbar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.White;
            this.foreverClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = true;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.foreverClose1.Location = new System.Drawing.Point(706, 16);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 2;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // foreverMinimize1
            // 
            this.foreverMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverMinimize1.BackColor = System.Drawing.Color.White;
            this.foreverMinimize1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverMinimize1.DefaultLocation = false;
            this.foreverMinimize1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverMinimize1.Font = new System.Drawing.Font("Marlett", 12F);
            this.foreverMinimize1.Location = new System.Drawing.Point(669, 16);
            this.foreverMinimize1.Name = "foreverMinimize1";
            this.foreverMinimize1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverMinimize1.Size = new System.Drawing.Size(18, 18);
            this.foreverMinimize1.TabIndex = 0;
            this.foreverMinimize1.Text = "foreverMinimize1";
            this.foreverMinimize1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm Login;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private ReaLTaiizor.Controls.ForeverStatusBar statbar;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Username_LOGIN;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Password_LOGIN;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnLogin;
        private ReaLTaiizor.Controls.ForeverLabel lblUser_LOGIN;
        private ReaLTaiizor.Controls.ForeverLabel lblPass_LOGIN;
        private ReaLTaiizor.Controls.ForeverToggle swtch_showpass_LOGIN;
        private ReaLTaiizor.Controls.ForeverLabel lblShwPass_LOGIN;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnSignup;
    }
}