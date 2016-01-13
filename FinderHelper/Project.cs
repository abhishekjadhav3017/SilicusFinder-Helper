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

        [Required(ErrorMessage = "Project Name can't be blank")]
        [StringLength(100, ErrorMessage = "Project Name  should contain less than 100 characters")]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [StringLength(250, ErrorMessage = "Description should contain less than 250 characters")]
        public string Description { get; set; }

        [Display(Name = "Project Type")]
        public ProjectType ProjectType { get; set; }

        public EngagementType EngagementType { get; set; }

        [Required(ErrorMessage = "Start Date can't be blank")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }         // have to make it nullable or not

        [Required(ErrorMessage = "Expected End_Date can't be blank")]
        [Display(Name = "Expected End_Date")]
        public DateTime? ExpectedEndDate { get; set; }

        [Required(ErrorMessage = "Actual End_Date can't be blank")]
        [Display(Name = "Actual End_Date")]
        public DateTime? ActualEndDate { get; set; }

        [Required(ErrorMessage = "Engagement Manager Id can't be blank")]
        [Display(Name = "Project Name")]
        public int EngagementManagerId { get; set; }

        [Required(ErrorMessage = "Project Manager Id can't be blank")]
        [Display(Name = "Project Manager Id")]
        public int ProjectManagerId { get; set; }

        [StringLength(150, ErrorMessage = "Additional Notes should contain less than 150 characters")]
        [Display(Name = "Additional Notes")]
        public string AdditionalNotes { get; set; }

        [Display(Name = "Technology Id")]
        public int TechnologyId { get; set; }    // have some issue with Technology
        
        public virtual List<Employee> Employee { get; set; }

        public int SkillSetId { get; set; }
        [Display(Name = "Skill Set")]
        public virtual List<SkillSet> SkillSet { get; set; }
    }
}