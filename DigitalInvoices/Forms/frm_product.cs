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
    public partial class frm_product : Form
    {
        public frm_product()
        {
            InitializeComponent();
        }

        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            Utility.ClearControls(this);
        }

        private void bttn_Reset_Click_1(object sender, EventArgs e)
        {
            Utility.ClearControls(this);
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private async void bttn_Save_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Name = txt_ProductName.Text.Trim(),
                HsCode = txt_HsCode.Text.Trim(),
                UoM = cmb_UoM.Text,
                UnitPrice = decimal.Parse(txt_UnitPrice.Text.Trim()),
                SalesTaxRate = decimal.Parse(txt_ST.Text.Trim())
            };
            
            using var db = new AppDbContext();
            db.products.Add(product);

            await db.SaveChangesAsync();

            //Clears all controls on form
            Utility.ClearControls(this);

            MessageBox.Show("Product added successfully!");

        }
    }
}
