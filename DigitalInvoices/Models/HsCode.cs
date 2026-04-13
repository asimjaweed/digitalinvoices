using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class HsCode
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;       // 0101.2100
        public string Description { get; set; } = string.Empty;

        public decimal DefaultRate { get; set; }       // Local reference only

        public string ParentCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
