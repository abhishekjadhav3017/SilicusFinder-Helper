using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilicusFinderDemo_Models
{
    public class Location
    {
        public Building Building { get; set; }
        public FloorNumber FloorNumber { get; set; }
        public string DeskNumber { get; set; }
    }
}
