using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism5.Model
{
    public class GeometricFigure
    {
        protected int numberOfSides;

        public virtual void Accept()
        {
            Console.Write("Enter number of sides: ");
            numberOfSides = int.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Number of sides: " + numberOfSides);
        }

        public virtual double ComputeArea()
        {
            return 0;
        }
    }
}
