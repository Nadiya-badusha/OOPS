using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism5.Model
{
    public class CircleFigure:GeometricFigure
    {
        protected double radius;

        public override void Accept()
        {
            numberOfSides = 0; // Circle has no sides
            Console.Write("Enter radius of circle: ");
            radius = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"Circle - Radius: {radius}");
            Console.WriteLine("Number of sides: " + numberOfSides);
        }

        public override double ComputeArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
