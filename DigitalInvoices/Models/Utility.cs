using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public static class Utility
    {
        public static void ClearControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear(); // clears textbox
                }
                else if (ctrl is ComboBox combo)
                {
                    combo.SelectedIndex = -1;   // clears selection
                    combo.Text = string.Empty;  // clears text
                }
                else if (ctrl.HasChildren)
                {
                    // Recursively check child controls (like GroupBox, Panel)
                    ClearControls(ctrl);
                }
            }
        }

        
            public static List<Customer> GetCustomers()
            {
                using var db = new AppDbContext();
                return db.customers.ToList();
            }

        public static List<Product> GetProducts()
        {
            using var db = new AppDbContext();
            return db.products.ToList();
        }

        public static List<Scenario> GetScenarios()
        {
            using var db = new AppDbContext();
            return db.scenarios
                .Select(s => new Scenario
                {
                    Code =s.Code,
                    //Description = s.Description,
                    Description = s.Code + "--" + s.Description,
                    //Display = s.Code + "--" +s.Description,

                }).ToList();
            
        }


        public static Invoice BuildInvoiceFromForm(
        DateTimePicker dtp_Date, Seller seller, Customer customer, ListView listView1)
        {
            var invoice = new Invoice
            {
                InvoiceType = "Sale Invoice",
                InvoiceDate = dtp_Date.Value,
                SellerNTNCNIC = seller?.CNIC,
                SellerBusinessName = seller?.FullName,
                SellerProvince = seller?.Province,
                SellerAddress = seller?.Address,
                BuyerNTNCNIC = customer?.CNIC,
                BuyerBusinessName = customer?.BusinessName,
                BuyerProvince = customer?.Province,
                BuyerAddress = customer?.Address,
                BuyerRegistrationType = customer?.RegistrationType,
                CreatedAt = DateTime.Now,
                Items = new List<InvoiceItem>()
            };

            foreach (ListViewItem lvItem in listView1.Items)
            {
                var item = new InvoiceItem
                {
                    HsCode = lvItem.SubItems[0].Text,
                    ProductDescription = lvItem.SubItems[1].Text,
                    Rate = decimal.Parse(lvItem.SubItems[2].Text),
                    UoM = lvItem.SubItems[3].Text,
                    Quantity = decimal.Parse(lvItem.SubItems[4].Text),
                    TotalValues = decimal.Parse(lvItem.SubItems[5].Text),
                    ValueSalesExcludingST = decimal.Parse(lvItem.SubItems[6].Text),
                    FixedNotifiedValueOrRetailPrice = decimal.Parse(lvItem.SubItems[7].Text),
                    SalesTaxApplicable = decimal.Parse(lvItem.SubItems[8].Text),
                    SalesTaxWithheldAtSource = decimal.Parse(lvItem.SubItems[9].Text),
                    ExtraTax = decimal.Parse(lvItem.SubItems[10].Text),
                    FurtherTax = decimal.Parse(lvItem.SubItems[11].Text),
                    SroScheduleNo = lvItem.SubItems[12].Text,
                    FedPayable = decimal.Parse(lvItem.SubItems[13].Text),
                    Discount = decimal.Parse(lvItem.SubItems[14].Text),
                    SroItemSerialNo = lvItem.SubItems[16].Text
                };

                invoice.Items.Add(item);
            }

            return invoice;
        }


        public static async Task<bool> ValidateInvoiceAsync(Invoice invoice, string token)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var json = JsonSerializer.Serialize(invoice);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://gw.fbr.gov.pk/di_data/v1/di/validateinvoicedata_sb", content);

            if (response.IsSuccessStatusCode)
            {
                // Optionally inspect the raw response text
                var result = await response.Content.ReadAsStringAsync();

                // If your API returns "true"/"false" or "ok"/"error", check it directly
                if (result.Contains("true") || result.Contains("ok"))
                    return true;
                else
                    return false;
            }

            return false;
        }


    }
}
    

