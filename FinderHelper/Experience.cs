using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Experience
    {
        [Required(ErrorMessage = "Please enter 0 if you dont have Experience")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter 0 if you dont have Experience")]
        public int? Month { get; set; }
    }
}