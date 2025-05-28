using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    public class Employee
    {

       
            public string Name { get; set; }
            public string Position { get; set; }
            public int Experience { get; set; } // In years
       
        //public int Id { get; set; } //Auto-generated 4 didgit
        //    public string Name { get; set; }
        //    public DateTime DateOfJoining { get; set; }// should be with in last 5 days
        //    public decimal Salary { get; set; } //accepts only digits

            //object oriented class model
            //many to one

        //    public bool InService { get; set; }

        
        //public string Position;
        //public int Experience;
        public Employee()
        {

        }
        public Employee(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} - {Position} ({Experience} years)");
        }
    }
}

