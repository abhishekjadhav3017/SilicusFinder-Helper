using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Contact
    {
        [Key]
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public int? MobileNumber { get; set; }
    }
}
