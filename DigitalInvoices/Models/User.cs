using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = "123";
        public DateTime CreatedAt { get; set; } = DateTime.Now;  
        public bool Status { get; set; } = true;
    }
}
