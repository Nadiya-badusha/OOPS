using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence3.Model
{
    public class Employee
    {
        //data members
        public int EmpNo;
        public string Name;
        public string Designation;
        public double BasicPay;

        //userinput
        public virtual void ReadData()
        {
            Console.Write("Enter Employee Number: ");
            EmpNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();

            Console.Write("Enter Basic Pay: ");
            BasicPay = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void DisplayData()
        {
            Console.WriteLine($"\nEmployee No: {EmpNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Basic Pay: {BasicPay}");
        }
    }
}
