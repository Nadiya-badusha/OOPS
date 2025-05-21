using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence3.Model
{
    public class Executive:Employee
    {
        public override void ReadData()
        {
            base.ReadData();

            // Enforce Basic Pay condition
            while (BasicPay <= 10000)
            {
                Console.WriteLine("Executives must have Basic Pay greater than Rs.10,000.");
                Console.Write("Please enter Basic Pay again: ");
                BasicPay = Convert.ToDouble(Console.ReadLine());
            }
        }

        public override void DisplayData()
        {
            Console.WriteLine("\n--- Executive Details ---");
            base.DisplayData();
        }
    }
}
