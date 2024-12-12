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
    public partial class MonitoringForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5087/api/Computers")
        };
        public MonitoringForm()
        {
            InitializeComponent();
            LoadComputers();
        }
        private async void LoadComputers()
        {
            try
            {
                var response = await httpClient.GetAsync("Computers");
                response.EnsureSuccessStatusCode();

                var responseData = await response.Content.ReadAsStringAsync();
                var computers = JsonConvert.DeserializeObject<List<ComputerModel>>(responseData);

                dgvComputers.DataSource = computers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading computers: {ex.Message}");
            }
        }
        public class ComputerModel
        {
            public int Id { get; set; }
            public string ComputerName { get; set; }
            public string Status { get; set; }
            public string Processor { get; set; }
            public string RAM { get; set; }
            public string Storage { get; set; }
            public string GraphicsCard { get; set; }
            public string OperatingSystem { get; set; }
            public DateTime LastUpdated { get; set; }
        }

        private async void btnAddComputer_Click(object sender, EventArgs e)
        {
            var newComputer = new
            {
                ComputerName = txb_CompName.Text,
                Status = cbx_CompStatus.SelectedItem?.ToString(),
                Processor = txb_CompProcessor.Text,
                RAM = txb_CompRAM.Text,
                Storage = txb_CompStorage.Text,
                GraphicsCard = txb_CompGraphicsCard.Text,
                OperatingSystem = txb_CompOS.Text
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(newComputer), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("Computers", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Computer added successfully!");
                    LoadComputers();
                }
                else
                {
                    MessageBox.Show($"Failed to add computer: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnEditComputer_Click(object sender, EventArgs e)
        {
            if (dgvComputers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a computer to edit.");
                return;
            }

            // Get the selected computer
            var selectedComputer = (ComputerModel)dgvComputers.SelectedRows[0].DataBoundItem;

            // Create the updated computer object
            var updatedComputer = new
            {
                Id = selectedComputer.Id, // Ensure the ID is sent
                ComputerName = txb_CompName.Text.Trim(),
                Status = cbx_CompStatus.SelectedItem?.ToString() ?? "Offline", // Default to "Offline" if null
                Processor = txb_CompProcessor.Text.Trim(),
                RAM = txb_CompRAM.Text.Trim(),
                Storage = txb_CompStorage.Text.Trim(),
                GraphicsCard = txb_CompGraphicsCard.Text.Trim(),
                OperatingSystem = txb_CompOS.Text.Trim()
            };

            try
            {
                // Serialize the updated object and send a PUT request
                var content = new StringContent(JsonConvert.SerializeObject(updatedComputer), Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync($"Computers/{updatedComputer.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Computer updated successfully!");
                    LoadComputers(); // Refresh the DataGridView
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to update computer: {response.StatusCode} - {error}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDelComputer_Click(object sender, EventArgs e)
        {
            if (dgvComputers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a computer to delete.");
                return;
            }

            // Get the selected computer
            var selectedComputer = (ComputerModel)dgvComputers.SelectedRows[0].DataBoundItem;

            try
            {
                // Call the DELETE API
                var response = await httpClient.DeleteAsync($"Computers/{selectedComputer.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Computer deleted successfully!");
                    LoadComputers(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show($"Failed to delete computer: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRefreshComputer_Click(object sender, EventArgs e)
        {
            LoadComputers();
        }

        private void pbxManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.Show();
        }

        private void pbxDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
