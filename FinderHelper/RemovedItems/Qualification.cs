using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        public Degree Degree { get; set; }

        [Required(ErrorMessage = "University can't be blank")]
        public string University { get; set; }

        public Division Division { get; set; }
    }
}