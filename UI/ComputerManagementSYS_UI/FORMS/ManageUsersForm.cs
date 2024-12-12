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
    public partial class ManageUsersForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5087/api/UserManagement")
        };
        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                var response = await httpClient.GetAsync("UserManagement");
                response.EnsureSuccessStatusCode();

                var responseData = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<UserModel>>(responseData);

                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public class UserModel
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        private async void btnAddUsers_Click(object sender, EventArgs e)
        {
            var newUser = new
            {
                Username = txb_Username_Manage.Text,
                Password = txb_Password_Manage.Text
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("UserManagement", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User added successfully!");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show($"Failed to add user: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDelUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var selectedUser = (UserModel)dgvUsers.SelectedRows[0].DataBoundItem;
            try
            {
                var response = await httpClient.DeleteAsync($"UserManagement/{selectedUser.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User deleted successfully!");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show($"Failed to delete user: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnEditUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            var selectedUser = (UserModel)dgvUsers.SelectedRows[0].DataBoundItem;
            var updatedUser = new
            {
                Username = txb_Username_Manage.Text,
                Password = txb_Password_Manage.Text
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(updatedUser), Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync($"UserManagement/{selectedUser.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User updated successfully!");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show($"Failed to update user: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void pbxDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not header or empty space
            if (e.RowIndex >= 0 && e.RowIndex < dgvUsers.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];

                // Populate the TextBoxes with the values from the selected row
                txb_Username_Manage.Text = selectedRow.Cells["Username"].Value?.ToString() ?? string.Empty;
                txb_Password_Manage.Text = string.Empty; // Clear password for security reasons
            }
        }

        private void pbxReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonitoringForm monitoringForm = new MonitoringForm();
            monitoringForm.Show();
        }
    }
}
