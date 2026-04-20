using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string BusinessName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;      
        public string RegistrationType { get; set; } = string.Empty;
        //public string WebSite { get; set; } = string.Empty;
        public string AccountNo { get; set; } = string.Empty;
        public string NTN { get; set; } = string.Empty;     
        public string STN { get; set; } = string.Empty;     
        public string CNIC { get; set; } = string.Empty;    
        public bool Status { get; set; } = true;

    }
}
