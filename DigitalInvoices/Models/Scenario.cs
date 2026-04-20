using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class Scenario
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;
        public string SaleType { get; set; } = string.Empty;
        public string Display { get; set; } = string.Empty; 
    }
}
