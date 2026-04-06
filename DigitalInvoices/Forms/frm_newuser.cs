using DigitalInvoices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalInvoices
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fullname.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            // Basic Validation
            if (string.IsNullOrWhiteSpace(txt_fullname.Text))
            {
                MessageBox.Show("Full Name is required");
                txt_fullname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Username is required");
                txt_username.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Password is required");
                txt_password.Focus();
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    using (var tran = db.Database.BeginTransaction())
                    {
                        try
                        {
                            // Check duplicate username
                            var existingUser = db.Users
                                .FirstOrDefault(x => x.Username == txt_username.Text);

                            if (existingUser != null)
                            {
                                MessageBox.Show("Username already exists");
                                return;
                            }

                            User user = new User();

                            user.FullName = txt_fullname.Text.Trim();
                            user.Username = txt_username.Text.Trim();
                            //user.Password = txt_password.Text.Trim();
                            user.Password = HashPassword(txt_password.Text).Trim();
                            //user.Status = 

                            db.Users.Add(user);

                            db.SaveChanges();

                            tran.Commit();

                            MessageBox.Show("User added successfully");

                            ClearForm();
                        }
                        catch (Exception)
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //Clear all controls
        private void ClearForm()
        {
            txt_fullname.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            //cmbStatus.SelectedIndex = 0;

            txt_fullname.Focus();
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
    }
    
}
