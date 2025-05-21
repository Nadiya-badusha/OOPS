using System;
using Polymorphism1.Model;
namespace Polymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Design a class Rectangle consists of two attributes x-coordinate and y
                coordinate. Design two constructors and methods for setting and getting the 
                attributes of class Rectangle. Incorporate   a method getArea() to compute the 
                area of the Rectangle. */


            // Using parameterized constructor 
            //user input

            Console.WriteLine("\nEnter x-coordinate for Rectangle :");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y-coordinate for Rectangle :");
            int y = Convert.ToInt32(Console.ReadLine());

            //object creation
            Rectangle rect = new Rectangle(x, y);
            Console.WriteLine("Rectangle 2 Area: " + rect.GetArea());
        }


    }
    }

