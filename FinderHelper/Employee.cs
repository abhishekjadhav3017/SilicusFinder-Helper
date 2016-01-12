using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name can't be blank")]
        [StringLength(20, ErrorMessage = "First Name should contain less than 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "Middle Name should contain less than 20 characters")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name can't be blank")]
        [StringLength(20, ErrorMessage = "Last Name should contain less than 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Employee Type")]
      //  [Required(ErrorMessage = "Please select Employee Type")]
        public EmployeeType EmployeeType { get; set; }

        [Display(Name = "Total Experience")]
      //  [Required(ErrorMessage = "Enter your Total Experience")]
        public Experience TotalExperience { get; set; }

        [Display(Name = "Silicus Experience")]
        //  [Required(ErrorMessage = "Enter your Silicus Experience")]
        public Experience SilicusExperience { get; set; }

        [Display(Name = "Highest Qualification")]
      //  [Required(ErrorMessage = "Enter your Highest Qualification")]
        public Qualification HighestQualification { get; set; }

        [Display(Name = "Skill Set")]
     //   [Required(ErrorMessage = "Enter your Skills")]
        public SkillSet SkillSet { get; set; }

       // [Required(ErrorMessage = "Enter your Location")]
        public Location Location { get; set; }

     //   [Required(ErrorMessage = "Please enter Contact")]
        public Contact Contact { get; set; }

        public List<Project> Project { get; set; }   // rename at the time of mapping otherwise Project_ProjectId column will get created
    }
}