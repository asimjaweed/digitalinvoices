using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; } // Local DB PK

        public string InvoiceType { get; set; } = string.Empty;
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        public string SellerNTNCNIC { get; set; } = string.Empty;
        public string SellerBusinessName { get; set; } = string.Empty;
        public string SellerProvince { get; set; } = string.Empty ;
        public string SellerAddress { get; set; } = string.Empty;

        public string BuyerNTNCNIC { get; set; } = string.Empty;
        public string BuyerBusinessName { get; set; } = string.Empty;
        public string BuyerProvince { get; set; } = string.Empty;
        public string BuyerAddress { get; set; } = string.Empty;
        public string BuyerRegistrationType { get; set; } = string.Empty;

        public string InvoiceRefNo { get; set; } = string.Empty;
        public string ScenarioId { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

            // Navigation Property (Master → Detail)
        public List<InvoiceItem>? Items { get; set; }
        }
    }
}
