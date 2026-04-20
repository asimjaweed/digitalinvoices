using DigitalInvoices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalInvoices
{
    public partial class InvoiceForm : Form
    {
        private Customer? customer;
        private Product? product;
        private Seller? seller;
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void InvoiceForm_Load(object sender, EventArgs e)
        {
            //Getting Customer list for customer combo
            List<Customer> customers = Utility.GetCustomers();
            cmb_customer.DataSource = customers;
            cmb_customer.DisplayMember = "BusinessName"; // adjust to your column
            cmb_customer.ValueMember = "Id";
            cmb_customer.SelectedIndex = -1; // no selection by default


            //Getting product list for product_combo
            List<Product> products = Utility.GetProducts();
            cmb_product.DataSource = products;
            cmb_product.DisplayMember = "Name"; // adjust to your column
            cmb_product.ValueMember = "Id";
            cmb_product.SelectedIndex = -1; // no selection by default

            //Getting Scenaio List
            List<Scenario> scenarios = Utility.GetScenarios();
            cmb_Scenario.DataSource = scenarios;
            cmb_Scenario.DisplayMember = "Description";   // shows "Code - Description"
            cmb_Scenario.ValueMember = "Code";        // underlying value
            cmb_Scenario.SelectedIndex = -1;


            //Configure ListView
            listView1.View = View.Details;

            listView1.Columns.Add("Invoice Type", 120);
            listView1.Columns.Add("Invoice Date", 120);
            listView1.Columns.Add("Seller CNIC", 120);
            listView1.Columns.Add("Seller Business Name", 150);
            listView1.Columns.Add("Seller Province", 120);
            listView1.Columns.Add("Seller Address", 200);
            listView1.Columns.Add("Buyer CNIC", 120);
            listView1.Columns.Add("Buyer Business Name", 150);
            listView1.Columns.Add("Buyer Province", 120);
            listView1.Columns.Add("Buyer Address", 200);
            listView1.Columns.Add("Buyer Registration", 150);
            listView1.Columns.Add("Invoice Ref No", 120);
            listView1.Columns.Add("Scenario Id", 100);
            listView1.Columns.Add("HS Code", 100);
            listView1.Columns.Add("Product Description", 150);
            listView1.Columns.Add("Rate", 100);
            listView1.Columns.Add("UOM", 80);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Total Value", 120);
            listView1.Columns.Add("Value Sales Excluding ST", 150);
            listView1.Columns.Add("Fixed/Notified Value", 150);
            listView1.Columns.Add("Sales Tax Applicable", 150);
            listView1.Columns.Add("Sales Tax Withheld", 150);
            listView1.Columns.Add("Extra Tax", 120);
            listView1.Columns.Add("Further Tax", 120);
            listView1.Columns.Add("SRO Schedule No", 150);
            listView1.Columns.Add("FED Payable", 120);
            listView1.Columns.Add("Discount", 120);
            listView1.Columns.Add("Sale Type", 120);
            listView1.Columns.Add("SRO Item Serial No", 150);

            listView1.FullRowSelect = true;
            listView1.GridLines = true;



            //Form dimensions
            lbl_formDimensions.Text = $"Form Size: Width = {this.Width}, Height = {this.Height}";


        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_customer.SelectedValue is int customerId)
            {
                using var db = new AppDbContext();
                customer = db.customers.FirstOrDefault(c => c.Id == customerId);
            }
        }



        private void bttn_Reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)ctrl).Clear();
                }
                else
                {
                    // Recursively check child controls
                    ClearTextBoxes(ctrl);
                }
            }
        }

        private async void bttn_Add_Click(object sender, EventArgs e)
        {
            //Applicatio Context variable
            var db = new AppDbContext();


            //Getging Seller information from db
            seller = db.sellers.FirstOrDefault();

            //Checking if customer selected from list
            if (cmb_customer.SelectedValue is int customerId)
            {
                customer = db.customers?.FirstOrDefault(c => c.Id == customerId);
            }

            if (cmb_product.SelectedValue is int productsId)
            {
                product = db.products?.FirstOrDefault(c => c.Id == productsId);
            }

            //Adding controls values from form into listview
            ListViewItem item = new ListViewItem("Sale Invoice");

            // Add subitems in the same order as your columns
            item.SubItems.Add(dtp_Date.Value.ToString("yyyy-MM-dd"));

            //Seller information
            item.SubItems.Add(seller?.CNIC);
            item.SubItems.Add(seller?.BusinessName);
            item.SubItems.Add(seller?.Province);
            item.SubItems.Add(seller?.Address);

            //Customer information
            item.SubItems.Add(customer?.CNIC);
            item.SubItems.Add(customer?.BusinessName);
            item.SubItems.Add(customer?.Province);
            item.SubItems.Add(customer?.Address);
            item.SubItems.Add(customer?.RegistrationType);
            item.SubItems.Add(txt_InvoiceRefNo.Text);
            item.SubItems.Add(cmb_Scenario.Text);

            //Invoice items details
            item.SubItems.Add(product?.HsCode);
            item.SubItems.Add(cmb_product.Text);
            item.SubItems.Add(txt_Rate.Text);
            item.SubItems.Add(cmb_Uom.Text);
            item.SubItems.Add(cmb_Qty.Text);
            item.SubItems.Add(txt_TotalValue.Text);
            item.SubItems.Add(txt_ValueExcludingST.Text);
            item.SubItems.Add(txt_FixedNotifiedValue.Text);
            item.SubItems.Add(txt_STApplicable.Text);
            item.SubItems.Add(txt_STWithoutSource.Text);
            item.SubItems.Add(txt_ExtraTax.Text);
            item.SubItems.Add(txt_FurtherTax.Text);
            item.SubItems.Add(txt_SroSchedule.Text);
            item.SubItems.Add(txt_FedPayable.Text);
            item.SubItems.Add(txt_Discount.Text);
            item.SubItems.Add(txt_SaleType.Text);
            item.SubItems.Add(txt_SroItemNo.Text);

            // Finally add the item to the ListView
            listView1.Items.Add(item);
        }

        private async void bttn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure customer is selected
                if (customer == null)
                {
                    MessageBox.Show("Please select a customer.");
                    return;
                }

                // Build invoice
                var invoice = new Invoice
                {
                    InvoiceType = "Sale Invoice",
                    InvoiceDate = dtp_Date.Value,

                    // Seller info (constant)
                    SellerNTNCNIC = seller.CNIC,
                    SellerBusinessName = seller.FullName,
                    SellerProvince = seller.Province,
                    SellerAddress = seller.Address,

                    // Customer info (from DB)
                    BuyerNTNCNIC = customer.CNIC,
                    BuyerBusinessName = customer.BusinessName,
                    BuyerProvince = customer.Province,
                    BuyerAddress = customer.Address,
                    BuyerRegistrationType = customer.RegistrationType,

                    CreatedAt = DateTime.Now,
                    Items = new List<InvoiceItem>()
                };

                // Collect items from ListView
                foreach (System.Windows.Forms.ListViewItem lvItem in listView1.Items)
                {
                    var item = new InvoiceItem
                    {
                        HsCode = lvItem.SubItems[13].Text,
                        ProductDescription = lvItem.SubItems[14].Text,
                        Rate = decimal.Parse(lvItem.SubItems[15].Text),
                        UoM = lvItem.SubItems[16].Text,
                        Quantity = decimal.Parse(lvItem.SubItems[17].Text),
                        TotalValues = decimal.Parse(lvItem.SubItems[18].Text),

                        ValueSalesExcludingST = decimal.Parse(lvItem.SubItems[19].Text),
                        FixedNotifiedValueOrRetailPrice = decimal.Parse(lvItem.SubItems[20].Text),
                        SalesTaxApplicable = decimal.Parse(lvItem.SubItems[21].Text),
                        SalesTaxWithheldAtSource = decimal.Parse(lvItem.SubItems[22].Text),
                        ExtraTax = decimal.Parse(lvItem.SubItems[23].Text),
                        FurtherTax = decimal.Parse(lvItem.SubItems[24].Text),
                        SroScheduleNo = lvItem.SubItems[25].Text,
                        FedPayable = decimal.Parse(lvItem.SubItems[26].Text),
                        Discount = decimal.Parse(lvItem.SubItems[27].Text),
                        //SaleType= lvItem.SubItems[15].Text,
                        SroItemSerialNo = lvItem.SubItems[28].Text

                    };

                    invoice.Items.Add(item);
                }

                // Save to DB
                using var db = new AppDbContext();
                db.invoices.Add(invoice);
                await db.SaveChangesAsync();
                MessageBox.Show("Data has been saved successfully");

                //MessageBox.Show("Invoice saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving invoice: {ex.Message}");
            }


        }

        private async void btt_ValidateData_Click(object sender, EventArgs e)
        {
            //https://gw.fbr.gov.pk/di_data/v1/di/validateinvoicedata_sb
            //Sandbox Securirty Token: 4ed8cd19 - 46db - 359c - aa86 - 3b0ab44a56eb
            string token = "4ed8cd19-46db-359c-aa86-3b0ab44a56eb"; // Replace with actual token

            ///var invoice=Utility.ValidateInvoiceAsync(Invoice invoice, token);

            using var client = new HttpClient();

            // Add bearer token
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Serialize invoice to JSON
           
            // Call validation endpoint
            var response = await client.PostAsync("https://gw.fbr.gov.pk/di_data/v1/di/validateinvoicedata_sb", content);

            


        }

        //public async Task SaveToLocalDbAsync(Invoice invoice)
        //{
        //    using var db = new AppDbContext();
        //    db.invoices.Add(invoice);
        //    await db.SaveChangesAsync();
        //}
    }
}
