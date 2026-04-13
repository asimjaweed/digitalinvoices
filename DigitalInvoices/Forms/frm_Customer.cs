using DigitalInvoices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalInvoices.Forms
{
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bttn_AddRecrod_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer()
                {
                    FirstName = txt_FirstName.Text.Trim(),
                    LastName = txt_LastName.Text.Trim(),
                    BusinessName = txt_BusinessName.Text.Trim(),
                    Email = txt_EmailAddress.Text.Trim(),
                    Phone = txt_PhoneNo.Text.Trim(),
                    Mobile = txt_CellNo.Text.Trim(),
                    Address = txt_Address.Text.Trim(),
                    Province = cmb_Province.Text,
                    AccountNo = txt_AccNo.Text.Trim(),
                    NTN = txt_NTNNo.Text.Trim(),
                    STN = txt_STNNo.Text.Trim(),
                    CNIC = txt_CNIC.Text.Trim()
                };


                // Save to DB
                using var db = new AppDbContext();
                db.customers.Add(customer);

                await db.SaveChangesAsync();
                
                //Clears all controls on form
                Utility.ClearControls(this);

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void ClearControls(Control parent)
        //{
        //    foreach (Control ctrl in parent.Controls)
        //    {
        //        if (ctrl is TextBox txt)
        //        {
        //            txt.Clear(); // clears textbox
        //        }
        //        else if (ctrl is ComboBox combo)
        //        {
        //            combo.SelectedIndex = -1;   // clears selection
        //            combo.Text = string.Empty;  // clears text
        //        }
        //        else if (ctrl.HasChildren)
        //        {
        //            // Recursively check child controls (like GroupBox, Panel)
        //            ClearControls(ctrl);
        //        }
        //    }
       // }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Utility.ClearControls(this);
        }
    }
}
