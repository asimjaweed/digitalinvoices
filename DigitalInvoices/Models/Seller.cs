using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvoices.Models
{
    public class Seller
    {
        int Id { get; set; }    
        string RegistrationNo { get; set; } = string.Empty;
        string Name { get; set; } = string.Empty;   
        string BusinessName { get; set; } = string.Empty; 
        string Email { get; set; } = string.Empty;
        string Provice  { get; set; } = string.Empty;
        string Address { get; set; } = string.Empty;
        string CNIC { get; set; } = string.Empty;
        string NTN { get; set; } = string.Empty;
        string STN { get; set; } = string.Empty;



    }
}
