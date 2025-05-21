using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence1.Model
{
    public class Employee:Person
    {


        public double BP; // Basic Pay
        public double HR; // House Rent
        public double Sal; // Total Salary

        //employee method
        public void Get_Data()
        {
            Read_Data();
            Console.Write("Enter Basic Pay: ");
            BP = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter House Rent: ");
            HR = Convert.ToDouble(Console.ReadLine());
        }

        //employee method
        public void Compute_Sal()
        {
            Sal = BP + HR;
        }

        //employee method
        public void Show_Data()
        {
            Display_Data();
            Console.WriteLine($"Basic Pay: {BP}");
            Console.WriteLine($"House Rent: {HR}");
            Console.WriteLine($"Total Salary: {Sal}");
        }

    }
}
