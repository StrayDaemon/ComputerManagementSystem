namespace ComputerManagementSYS_UI.FORMS
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.Signup = new ReaLTaiizor.Forms.ForeverForm();
            this.btnSignup = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.lblPass_SIGNUP = new ReaLTaiizor.Controls.ForeverLabel();
            this.lblUser_SIGNUP = new ReaLTaiizor.Controls.ForeverLabel();
            this.txb_Password_SIGNUP = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txb_Username_SIGNUP = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            this.statbar = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.Signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.White;
            this.Signup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Signup.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Signup.Controls.Add(this.btnSignup);
            this.Signup.Controls.Add(this.lblPass_SIGNUP);
            this.Signup.Controls.Add(this.lblUser_SIGNUP);
            this.Signup.Controls.Add(this.txb_Password_SIGNUP);
            this.Signup.Controls.Add(this.txb_Username_SIGNUP);
            this.Signup.Controls.Add(this.foreverClose1);
            this.Signup.Controls.Add(this.foreverMinimize1);
            this.Signup.Controls.Add(this.statbar);
            this.Signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Signup.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Signup.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Signup.HeaderMaximize = false;
            this.Signup.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.Signup.Image = null;
            this.Signup.Location = new System.Drawing.Point(0, 0);
            this.Signup.MinimumSize = new System.Drawing.Size(210, 50);
            this.Signup.Name = "Signup";
            this.Signup.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.Signup.Sizable = false;
            this.Signup.Size = new System.Drawing.Size(736, 450);
            this.Signup.TabIndex = 0;
            this.Signup.Text = "Sign-up  |  Computer Management System";
            this.Signup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Signup.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSignup.Location = new System.Drawing.Point(308, 310);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Rounded = true;
            this.btnSignup.Size = new System.Drawing.Size(160, 40);
            this.btnSignup.TabIndex = 13;
            this.btnSignup.Text = "SIGN UP";
            this.btnSignup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblPass_SIGNUP
            // 
            this.lblPass_SIGNUP.AutoSize = true;
            this.lblPass_SIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.lblPass_SIGNUP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass_SIGNUP.ForeColor = System.Drawing.Color.LightGray;
            this.lblPass_SIGNUP.Location = new System.Drawing.Point(62, 230);
            this.lblPass_SIGNUP.Name = "lblPass_SIGNUP";
            this.lblPass_SIGNUP.Size = new System.Drawing.Size(97, 28);
            this.lblPass_SIGNUP.TabIndex = 12;
            this.lblPass_SIGNUP.Text = "Password:";
            // 
            // lblUser_SIGNUP
            // 
            this.lblUser_SIGNUP.AutoSize = true;
            this.lblUser_SIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.lblUser_SIGNUP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_SIGNUP.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser_SIGNUP.Location = new System.Drawing.Point(62, 151);
            this.lblUser_SIGNUP.Name = "lblUser_SIGNUP";
            this.lblUser_SIGNUP.Size = new System.Drawing.Size(103, 28);
            this.lblUser_SIGNUP.TabIndex = 11;
            this.lblUser_SIGNUP.Text = "Username:";
            // 
            // txb_Password_SIGNUP
            // 
            this.txb_Password_SIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.txb_Password_SIGNUP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Password_SIGNUP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Password_SIGNUP.FocusOnHover = false;
            this.txb_Password_SIGNUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Password_SIGNUP.Location = new System.Drawing.Point(183, 230);
            this.txb_Password_SIGNUP.MaxLength = 32767;
            this.txb_Password_SIGNUP.Multiline = false;
            this.txb_Password_SIGNUP.Name = "txb_Password_SIGNUP";
            this.txb_Password_SIGNUP.ReadOnly = false;
            this.txb_Password_SIGNUP.Size = new System.Drawing.Size(416, 34);
            this.txb_Password_SIGNUP.TabIndex = 10;
            this.txb_Password_SIGNUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Password_SIGNUP.UseSystemPasswordChar = false;
            // 
            // txb_Username_SIGNUP
            // 
            this.txb_Username_SIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.txb_Username_SIGNUP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Username_SIGNUP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Username_SIGNUP.FocusOnHover = false;
            this.txb_Username_SIGNUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Username_SIGNUP.Location = new System.Drawing.Point(183, 151);
            this.txb_Username_SIGNUP.MaxLength = 32767;
            this.txb_Username_SIGNUP.Multiline = false;
            this.txb_Username_SIGNUP.Name = "txb_Username_SIGNUP";
            this.txb_Username_SIGNUP.ReadOnly = false;
            this.txb_Username_SIGNUP.Size = new System.Drawing.Size(416, 34);
            this.txb_Username_SIGNUP.TabIndex = 9;
            this.txb_Username_SIGNUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Username_SIGNUP.UseSystemPasswordChar = false;
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
            this.foreverClose1.TabIndex = 6;
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
            this.foreverMinimize1.TabIndex = 5;
            this.foreverMinimize1.Text = "foreverMinimize1";
            this.foreverMinimize1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
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
            this.statbar.TabIndex = 4;
            this.statbar.Text = "patualnathan@gmail.com";
            this.statbar.TextColor = System.Drawing.Color.White;
            this.statbar.TimeColor = System.Drawing.Color.White;
            this.statbar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.Signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Signup.ResumeLayout(false);
            this.Signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm Signup;
        private ReaLTaiizor.Controls.ForeverStatusBar statbar;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverLabel lblPass_SIGNUP;
        private ReaLTaiizor.Controls.ForeverLabel lblUser_SIGNUP;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Password_SIGNUP;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Username_SIGNUP;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnSignup;
    }
}