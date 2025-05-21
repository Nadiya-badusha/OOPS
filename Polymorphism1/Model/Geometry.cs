using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1.Model
{

    public class Rectangle
    {

        // datamembers
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        // Default constructor
        public Rectangle()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }

        // Parameterized constructor
        public Rectangle(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }


        // Method to calculate area
        public int GetArea()
        {
            return XCoordinate * YCoordinate;
        }

        // Omethod to return area in string format
        public string GetArea(string format)
        {
                return $"Area of rectangle is {GetArea()} square units.";
        }
    }
}
