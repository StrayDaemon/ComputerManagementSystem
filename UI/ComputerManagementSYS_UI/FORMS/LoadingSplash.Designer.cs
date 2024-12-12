namespace ComputerManagementSYS_UI
{
    partial class LoadingSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingSplash));
            this.Loading = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.prgbLoading = new ReaLTaiizor.Controls.ForeverProgressBar();
            this.lblLoading = new ReaLTaiizor.Controls.ForeverLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.White;
            this.Loading.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Loading.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Loading.Controls.Add(this.pictureBox1);
            this.Loading.Controls.Add(this.lblLoading);
            this.Loading.Controls.Add(this.prgbLoading);
            this.Loading.Controls.Add(this.foreverLabel1);
            this.Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Loading.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Loading.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Loading.HeaderMaximize = false;
            this.Loading.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.Loading.Image = null;
            this.Loading.Location = new System.Drawing.Point(0, 0);
            this.Loading.MinimumSize = new System.Drawing.Size(210, 50);
            this.Loading.Name = "Loading";
            this.Loading.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.Loading.Sizable = false;
            this.Loading.Size = new System.Drawing.Size(744, 484);
            this.Loading.TabIndex = 0;
            this.Loading.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Loading.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(65, 77);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(584, 54);
            this.foreverLabel1.TabIndex = 0;
            this.foreverLabel1.Text = "Computer Management System";
            // 
            // prgbLoading
            // 
            this.prgbLoading.BackColor = System.Drawing.Color.Transparent;
            this.prgbLoading.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.prgbLoading.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.prgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.prgbLoading.Location = new System.Drawing.Point(62, 376);
            this.prgbLoading.Maximum = 100;
            this.prgbLoading.MoveBalloon = true;
            this.prgbLoading.Name = "prgbLoading";
            this.prgbLoading.Pattern = true;
            this.prgbLoading.PercentSign = false;
            this.prgbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.prgbLoading.ShowBalloon = true;
            this.prgbLoading.Size = new System.Drawing.Size(652, 42);
            this.prgbLoading.TabIndex = 1;
            this.prgbLoading.Value = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoading.Location = new System.Drawing.Point(57, 345);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(95, 28);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ComputerManagementSYS_UI.Properties.Resources.computer_40dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            this.pictureBox1.Location = new System.Drawing.Point(227, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 484);
            this.Controls.Add(this.Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingSplash";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Loading.ResumeLayout(false);
            this.Loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm Loading;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverProgressBar prgbLoading;
        private ReaLTaiizor.Controls.ForeverLabel lblLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}