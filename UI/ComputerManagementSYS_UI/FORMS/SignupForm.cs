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
    public partial class SignupForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5087/api/signup")
        };

        public SignupForm()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            var newUser = new
            {
                Username = txb_Username_SIGNUP.Text,
                Password = txb_Password_SIGNUP.Text
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5087/api/signup") })
                {
                    var response = await httpClient.PostAsync("signup", content);

                    if (response.IsSuccessStatusCode)
                    {
                        statbar.Text = $"Signup successful! (Status: {response.StatusCode})";
                        MessageBox.Show("Signup successful!");
                        this.Hide();

                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        statbar.Text = $"Signup failed! (Status: {response.StatusCode})";
                        MessageBox.Show($"Signup failed: {response.StatusCode} - {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
