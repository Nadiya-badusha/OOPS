using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence1.Model
{
    public class Person
    {
        //data members
        public string Name { get; set; }
        public int Age { get; set; }


        //base method
        public void Read_Data()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        //base method
        public void Display_Data()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

    }
}
