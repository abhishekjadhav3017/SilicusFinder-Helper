using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SilicusFinderDemo_Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "First Name can't be blank")]
        [StringLength(20, ErrorMessage = "First Name should contain less than 20 characters")]
        [Display(Name = "First Name")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "First Name can't be blank")]
        [StringLength(20, ErrorMessage = "First Name should contain less than 20 characters")]
        [Display(Name = "First Name")]
        public string Description { get; set; }

        [Required(ErrorMessage = "First Name can't be blank")]
        [StringLength(20, ErrorMessage = "First Name should contain less than 20 characters")]
        [Display(Name = "First Name")]
        public ProjectType ProjectType { get; set; }
        public Engagement Engagement { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public int EngagementManagerId { get; set; }
        public int ProjectManagerId { get; set; }
        public string AdditionalNotes { get; set; }
        public int TechnologyId { get; set; }
        public List<Employee> Employee { get; set; }
    }
}