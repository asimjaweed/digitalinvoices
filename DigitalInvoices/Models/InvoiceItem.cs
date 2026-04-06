using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; } // FK
        public Invoice? Invoice { get; set; }

        public string HsCode { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string Rate { get; set; } = string.Empty;
        public string UoM { get; set; } = string.Empty;

        public decimal Quantity { get; set; }
        public decimal TotalValues { get; set; }
        public decimal ValueSalesExcludingST { get; set; }

        public decimal FixedNotifiedValueOrRetailPrice { get; set; }
        public decimal SalesTaxApplicable { get; set; }
        public decimal SalesTaxWithheldAtSource { get; set; }
        public decimal ExtraTax { get; set; }
        public decimal FurtherTax { get; set; }

        public string SroScheduleNo { get; set; } = string.Empty;
        public decimal FedPayable { get; set; }
        public decimal Discount { get; set; }

        public string SaleType { get; set; } = string.Empty;
        public string SroItemSerialNo { get; set; } = string.Empty;
    }
}
