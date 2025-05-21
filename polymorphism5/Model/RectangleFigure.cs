using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism5.Model
{
    public class RectangleFigure:GeometricFigure
    {
        protected double length;
        protected double breadth;

        public override void Accept()
        {
            numberOfSides = 4;  // Always 4 for rectangle
            Console.Write("Enter length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Enter breadth: ");
            breadth = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle - Length: {length}, Breadth: {breadth}");
            Console.WriteLine("Number of sides: " + numberOfSides);
        }

        public override double ComputeArea()
        {
            return length * breadth;
        }
    }
}
