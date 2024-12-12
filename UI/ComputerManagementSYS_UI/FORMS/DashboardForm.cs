using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManagementSYS_UI.FORMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void pbxManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.Show();
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pbxReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonitoringForm monitoringForm = new MonitoringForm();
            monitoringForm.Show();
        }
    }
}
