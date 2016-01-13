using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class SkillSet
    {
        [Key]
        public int SkillSetId { get; set; }

        [Required(ErrorMessage = "Name can't be blank")]
        [StringLength(30, ErrorMessage = "Name should contain less than 30 characters")]
        public string Name { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual List<Employee> Employees { get; set; }
                
        //[Required(ErrorMessage = "Technology Id can't be blank")]
        //[Display(Name = "Technology Id")]
        //public int TechnologyId { get; set; }
        
        //[Required(ErrorMessage = "Tools can't be blank")]
        //[StringLength(20, ErrorMessage = "Tools should contain less than 20 characters")]
        //public string Tools { get; set; }

        //[Required(ErrorMessage = "Description can't be blank")]
        //[StringLength(150, ErrorMessage = "Description should contain less than 150 characters")]
        //public string Description { get; set; }
    }
}