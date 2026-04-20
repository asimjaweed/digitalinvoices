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
    public partial class frm_seller : Form
    {
        public frm_seller()
        {
            InitializeComponent();
        }

        private async void bttn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var seller = new Seller()
                {
                    FullName = txt_FullName.Text.Trim(),
                    BusinessName = txt_BusinessName.Text.Trim(),
                    Email = txt_Email.Text.Trim(),
                    RegistrationNo = txt_RegNo.Text.Trim(),
                    Address = txt_Address.Text.Trim(),
                    Province = cmb_Province.Text,
                    //City = cmb_City.Text,
                    //AccountNo = txt_AccNo.Text.Trim(),
                    NTN = txt_NTN.Text.Trim(),
                    STN = txt_STN.Text.Trim(),
                    CNIC = txt_CNIC.Text.Trim()
                };


                // Save to DB
                using var db = new AppDbContext();
                db.sellers.Add(seller);

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
    }
}
