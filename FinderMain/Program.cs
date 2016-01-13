using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinderHelper.Data;
using SilicusFinderDemo_Models;

namespace FinderMain
{
    class Program
    {
        static void Main(string[] args)
        {
            FinderContext context = new FinderContext();

            context.SkillSets.Add(new SkillSet { Name = "master"});

            //context.Employees.Add(new Employee { FirstName = "Shivani", LastName = "Surana", Gender = Gender.Female, Contact = new Contact { EmailId = "anb@gmail.con" }, MiddleName ="hfkjdfh", EmployeeType = EmployeeType.Contract, HighestQualification = "fhkljadh"});
            context.SaveChanges();

            Console.WriteLine("Enter");
            Console.ReadKey();
        }
    }
}

// CubicalLocation = new CubicalLocation { Building = "B", DeskNumber =  "15", FloorNumber = 5  }