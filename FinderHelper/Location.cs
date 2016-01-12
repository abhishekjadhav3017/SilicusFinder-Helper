using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Location
    {
        [Required(ErrorMessage = "Building can't be blank")]
        public string Building { get; set; }
       // public Building Building { get; set; }

        [Required(ErrorMessage = "Floor Number can't be blank")]
        [Display(Name = "Floor Number")]
        public string FloorNumber { get; set; }
      //  public FloorNumber FloorNumber { get; set; }

        [Required(ErrorMessage = "Desk Number can't be blank")]
        [StringLength(10, ErrorMessage = "Desk Number should contain less than 10 characters")]
        [Display(Name = "Desk Number")]
        public string DeskNumber { get; set; }
    }
}