using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerManagementSYS_UI.FORMS;

namespace ComputerManagementSYS_UI
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5087/api/login")
        };

        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txb_Password_LOGIN.UseSystemPasswordChar = true; // Hide password by default
        }

        private void swtch_showpass_LOGIN_CheckedChanged(object sender)
        {
            // Toggle password visibility explicitly based on the switch's Checked state
            if (swtch_showpass_LOGIN.Checked)
            {
                txb_Password_LOGIN.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txb_Password_LOGIN.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txb_Username_LOGIN.Text; // User's username
            var password = txb_Password_LOGIN.Text; // User's plaintext password

            var loginPayload = new
            {
                Username = username,
                Password = password // Send plaintext password
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(loginPayload), Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5087/api/login") })
                {
                    var response = await httpClient.PostAsync("login", content);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        statbar.Text = $"Login successful! (Status: {response.StatusCode})";
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.ShowDialog();
                    }
                    else
                    {
                        statbar.Text = $"Login failed! (Status: {response.StatusCode})";
                        MessageBox.Show($"Login failed: {response.StatusCode} - {responseBody}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
