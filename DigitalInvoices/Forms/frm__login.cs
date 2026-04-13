using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalInvoices
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    string hashedPassword = HashPassword(txt_password.Text);

                    var user = db.users
                    .FirstOrDefault(x => x.Username == txt_username.Text
                    && x.Password == hashedPassword
                    && x.Status ==true);

                    if (user != null)
                    {
                        MessageBox.Show("Login Successful");
                        //Dashboard frm = new Dashboard();
                        //frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        

            var client = new HttpClient();
            var url = "https://gw.fbr.gov.pk/di_data/v1/di/postinvoicedata_sb";

            // Note: If IRIS says N/A, try sending the request without the Bearer header first.
            // If it fails with 401, you'll know the token IS required.
            var requestBody = new
            {
                sellerNTN = "6110117843017",
                invoiceNumber = "TEST-001",
                // Add other mandatory FBR fields here
            };

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            // Crucial Headers for FBR Gateway
            request.Headers.Add("Accept", "application/json");
            // request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "YOUR_TOKEN_HERE");

            try
            {
                var response = client.Send(request);
                var content = response.Content.ReadAsStringAsync();

                Console.WriteLine($"Status: {response.StatusCode}");
                Console.WriteLine($"Response: {content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection Error: {ex.Message}");
            }
        }
    }
}
