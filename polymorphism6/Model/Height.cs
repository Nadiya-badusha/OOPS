using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism6.Model
{
    internal class Height
    {
        public int Feet { get; set; }
        public int Inches { get; set; }

        // Constructor
        public Height(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
            Normalize(); // Ensure valid initial state
        }

        // Normalize to convert every 12 inches into 1 foot
        private void Normalize()
        {
            if (Inches >= 12)
            {
                Feet += Inches / 12;
                Inches %= 12;
            }
        }

        // Overload + operator to add 1 inch
        public static Height operator +(Height h, int value)
        {
            h.Inches += value;
            h.Normalize();
            return h;
        }

        // Display function
        public void Display()
        {
            Console.WriteLine($"Height: {Feet} feet {Inches} inches");
        }
    }
}
