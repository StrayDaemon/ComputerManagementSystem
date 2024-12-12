namespace ComputerManagementSYS_UI.FORMS
{
    partial class ManageUsersForm
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
            this.ManageUsers = new ReaLTaiizor.Forms.ForeverForm();
            this.gbxManageUsers = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.lblPass_Manage = new ReaLTaiizor.Controls.ForeverLabel();
            this.lblUser_Manage = new ReaLTaiizor.Controls.ForeverLabel();
            this.txb_Password_Manage = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txb_Username_Manage = new ReaLTaiizor.Controls.ForeverTextBox();
            this.btnRefreshUsers = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.btnDelUsers = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.btnEditUsers = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.btnAddUsers = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foreverLabel6 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.pbxDashboard = new System.Windows.Forms.PictureBox();
            this.pbxManageUsers = new System.Windows.Forms.PictureBox();
            this.pbxLogout = new System.Windows.Forms.PictureBox();
            this.pbxReport = new System.Windows.Forms.PictureBox();
            this.ManageUsers.SuspendLayout();
            this.gbxManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManageUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUsers
            // 
            this.ManageUsers.BackColor = System.Drawing.Color.White;
            this.ManageUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ManageUsers.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ManageUsers.Controls.Add(this.gbxManageUsers);
            this.ManageUsers.Controls.Add(this.foreverLabel1);
            this.ManageUsers.Controls.Add(this.pbxDashboard);
            this.ManageUsers.Controls.Add(this.panel1);
            this.ManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManageUsers.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ManageUsers.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ManageUsers.HeaderMaximize = false;
            this.ManageUsers.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ManageUsers.Image = null;
            this.ManageUsers.Location = new System.Drawing.Point(0, 0);
            this.ManageUsers.MinimumSize = new System.Drawing.Size(210, 50);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.ManageUsers.Sizable = true;
            this.ManageUsers.Size = new System.Drawing.Size(1165, 721);
            this.ManageUsers.TabIndex = 2;
            this.ManageUsers.Text = "Manage Users  |  Computer Management System";
            this.ManageUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ManageUsers.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // gbxManageUsers
            // 
            this.gbxManageUsers.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gbxManageUsers.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gbxManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.gbxManageUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gbxManageUsers.Controls.Add(this.lblPass_Manage);
            this.gbxManageUsers.Controls.Add(this.lblUser_Manage);
            this.gbxManageUsers.Controls.Add(this.txb_Password_Manage);
            this.gbxManageUsers.Controls.Add(this.txb_Username_Manage);
            this.gbxManageUsers.Controls.Add(this.btnRefreshUsers);
            this.gbxManageUsers.Controls.Add(this.btnDelUsers);
            this.gbxManageUsers.Controls.Add(this.btnEditUsers);
            this.gbxManageUsers.Controls.Add(this.btnAddUsers);
            this.gbxManageUsers.Controls.Add(this.dgvUsers);
            this.gbxManageUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbxManageUsers.Location = new System.Drawing.Point(253, 54);
            this.gbxManageUsers.Name = "gbxManageUsers";
            this.gbxManageUsers.ShowArrow = true;
            this.gbxManageUsers.ShowText = true;
            this.gbxManageUsers.Size = new System.Drawing.Size(900, 536);
            this.gbxManageUsers.TabIndex = 14;
            this.gbxManageUsers.Text = "Manage Users:";
            this.gbxManageUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            // 
            // lblPass_Manage
            // 
            this.lblPass_Manage.AutoSize = true;
            this.lblPass_Manage.BackColor = System.Drawing.Color.Transparent;
            this.lblPass_Manage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass_Manage.ForeColor = System.Drawing.Color.LightGray;
            this.lblPass_Manage.Location = new System.Drawing.Point(19, 461);
            this.lblPass_Manage.Name = "lblPass_Manage";
            this.lblPass_Manage.Size = new System.Drawing.Size(97, 28);
            this.lblPass_Manage.TabIndex = 16;
            this.lblPass_Manage.Text = "Password:";
            // 
            // lblUser_Manage
            // 
            this.lblUser_Manage.AutoSize = true;
            this.lblUser_Manage.BackColor = System.Drawing.Color.Transparent;
            this.lblUser_Manage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_Manage.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser_Manage.Location = new System.Drawing.Point(13, 394);
            this.lblUser_Manage.Name = "lblUser_Manage";
            this.lblUser_Manage.Size = new System.Drawing.Size(103, 28);
            this.lblUser_Manage.TabIndex = 15;
            this.lblUser_Manage.Text = "Username:";
            // 
            // txb_Password_Manage
            // 
            this.txb_Password_Manage.BackColor = System.Drawing.Color.Transparent;
            this.txb_Password_Manage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Password_Manage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Password_Manage.FocusOnHover = false;
            this.txb_Password_Manage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Password_Manage.Location = new System.Drawing.Point(134, 467);
            this.txb_Password_Manage.MaxLength = 32767;
            this.txb_Password_Manage.Multiline = false;
            this.txb_Password_Manage.Name = "txb_Password_Manage";
            this.txb_Password_Manage.ReadOnly = false;
            this.txb_Password_Manage.Size = new System.Drawing.Size(416, 34);
            this.txb_Password_Manage.TabIndex = 14;
            this.txb_Password_Manage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Password_Manage.UseSystemPasswordChar = false;
            // 
            // txb_Username_Manage
            // 
            this.txb_Username_Manage.BackColor = System.Drawing.Color.Transparent;
            this.txb_Username_Manage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_Username_Manage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txb_Username_Manage.FocusOnHover = false;
            this.txb_Username_Manage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_Username_Manage.Location = new System.Drawing.Point(134, 397);
            this.txb_Username_Manage.MaxLength = 32767;
            this.txb_Username_Manage.Multiline = false;
            this.txb_Username_Manage.Name = "txb_Username_Manage";
            this.txb_Username_Manage.ReadOnly = false;
            this.txb_Username_Manage.Size = new System.Drawing.Size(416, 34);
            this.txb_Username_Manage.TabIndex = 13;
            this.txb_Username_Manage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Username_Manage.UseSystemPasswordChar = false;
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefreshUsers.Location = new System.Drawing.Point(749, 467);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Rounded = false;
            this.btnRefreshUsers.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshUsers.TabIndex = 4;
            this.btnRefreshUsers.Text = "REFRESH";
            this.btnRefreshUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // btnDelUsers
            // 
            this.btnDelUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnDelUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnDelUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelUsers.Location = new System.Drawing.Point(749, 397);
            this.btnDelUsers.Name = "btnDelUsers";
            this.btnDelUsers.Rounded = false;
            this.btnDelUsers.Size = new System.Drawing.Size(120, 40);
            this.btnDelUsers.TabIndex = 3;
            this.btnDelUsers.Text = "DELETE";
            this.btnDelUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelUsers.Click += new System.EventHandler(this.btnDelUsers_Click);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEditUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditUsers.Location = new System.Drawing.Point(597, 467);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Rounded = false;
            this.btnEditUsers.Size = new System.Drawing.Size(120, 40);
            this.btnEditUsers.TabIndex = 2;
            this.btnEditUsers.Text = "EDIT";
            this.btnEditUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAddUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddUsers.Location = new System.Drawing.Point(597, 397);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Rounded = false;
            this.btnAddUsers.Size = new System.Drawing.Size(120, 40);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "ADD";
            this.btnAddUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(147, 21);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(722, 352);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(101, 149);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(100, 25);
            this.foreverLabel1.TabIndex = 2;
            this.foreverLabel1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.foreverLabel6);
            this.panel1.Controls.Add(this.pbxManageUsers);
            this.panel1.Controls.Add(this.pbxLogout);
            this.panel1.Controls.Add(this.foreverLabel5);
            this.panel1.Controls.Add(this.foreverLabel4);
            this.panel1.Controls.Add(this.pbxReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 669);
            this.panel1.TabIndex = 13;
            // 
            // foreverLabel6
            // 
            this.foreverLabel6.AutoSize = true;
            this.foreverLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.foreverLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel6.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel6.Location = new System.Drawing.Point(100, 400);
            this.foreverLabel6.Name = "foreverLabel6";
            this.foreverLabel6.Size = new System.Drawing.Size(69, 25);
            this.foreverLabel6.TabIndex = 12;
            this.foreverLabel6.Text = "Logout";
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.foreverLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel5.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel5.Location = new System.Drawing.Point(100, 196);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(124, 25);
            this.foreverLabel5.TabIndex = 10;
            this.foreverLabel5.Text = "Manage Users";
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.foreverLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel4.Location = new System.Drawing.Point(100, 300);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(139, 23);
            this.foreverLabel4.TabIndex = 8;
            this.foreverLabel4.Text = "Report / Monitor";
            // 
            // pbxDashboard
            // 
            this.pbxDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pbxDashboard.Image = global::ComputerManagementSYS_UI.Properties.Resources.dashboard_2_42dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.pbxDashboard.Location = new System.Drawing.Point(26, 129);
            this.pbxDashboard.Name = "pbxDashboard";
            this.pbxDashboard.Size = new System.Drawing.Size(69, 61);
            this.pbxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDashboard.TabIndex = 1;
            this.pbxDashboard.TabStop = false;
            this.pbxDashboard.Click += new System.EventHandler(this.pbxDashboard_Click);
            // 
            // pbxManageUsers
            // 
            this.pbxManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pbxManageUsers.Image = global::ComputerManagementSYS_UI.Properties.Resources.group_42dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.pbxManageUsers.Location = new System.Drawing.Point(25, 180);
            this.pbxManageUsers.Name = "pbxManageUsers";
            this.pbxManageUsers.Size = new System.Drawing.Size(69, 61);
            this.pbxManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxManageUsers.TabIndex = 9;
            this.pbxManageUsers.TabStop = false;
            // 
            // pbxLogout
            // 
            this.pbxLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pbxLogout.Image = global::ComputerManagementSYS_UI.Properties.Resources.logout_42dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.pbxLogout.Location = new System.Drawing.Point(25, 380);
            this.pbxLogout.Name = "pbxLogout";
            this.pbxLogout.Size = new System.Drawing.Size(69, 61);
            this.pbxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogout.TabIndex = 11;
            this.pbxLogout.TabStop = false;
            // 
            // pbxReport
            // 
            this.pbxReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pbxReport.Image = global::ComputerManagementSYS_UI.Properties.Resources.monitoring_42dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.pbxReport.Location = new System.Drawing.Point(25, 280);
            this.pbxReport.Name = "pbxReport";
            this.pbxReport.Size = new System.Drawing.Size(69, 61);
            this.pbxReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxReport.TabIndex = 7;
            this.pbxReport.TabStop = false;
            this.pbxReport.Click += new System.EventHandler(this.pbxReport_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 721);
            this.Controls.Add(this.ManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ManageUsers.ResumeLayout(false);
            this.ManageUsers.PerformLayout();
            this.gbxManageUsers.ResumeLayout(false);
            this.gbxManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManageUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm ManageUsers;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private System.Windows.Forms.PictureBox pbxDashboard;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel6;
        private System.Windows.Forms.PictureBox pbxManageUsers;
        private System.Windows.Forms.PictureBox pbxLogout;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private System.Windows.Forms.PictureBox pbxReport;
        private ReaLTaiizor.Controls.ForeverGroupBox gbxManageUsers;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnRefreshUsers;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnDelUsers;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnEditUsers;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnAddUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private ReaLTaiizor.Controls.ForeverLabel lblPass_Manage;
        private ReaLTaiizor.Controls.ForeverLabel lblUser_Manage;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Password_Manage;
        private ReaLTaiizor.Controls.ForeverTextBox txb_Username_Manage;
    }
}