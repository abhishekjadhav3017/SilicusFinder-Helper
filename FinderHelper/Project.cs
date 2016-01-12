using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilicusFinderDemo_Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
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