using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism5.Model
{
     public class SquareFigure:GeometricFigure
    {
        protected double side;

        public override void Accept()
        {
            numberOfSides = 4; // Always 4 for square
            Console.Write("Enter side length of square: ");
            side = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"Square - Side: {side}");
            Console.WriteLine("Number of sides: " + numberOfSides);
        }

        public override double ComputeArea()
        {
            return side * side;
        }
    }
}
