using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }    
        public string RegistrationNo { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;   
        public string BusinessName { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public string Province  { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CNIC { get; set; } = string.Empty;
        public string NTN { get; set; } = string.Empty;
        public string STN { get; set; } = string.Empty;



    }
}
