using polymorphism5.Model;

namespace polymorphism5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Design a class hierarchy with GeometricFigure as a base class  of a rectangle 
                class. GeometricFigure has attribute of no. of sides and member function to 
                accept values in attribute. RectangleFigure class has attributes for length and 
                breadth as well as member functions to calculate area, accept and display 
                values of attributes. Access the members through base class reference and 
                derived class reference. Design derived classes RectangleFigure, SquareFigure 
                and CircleFigure of base class GeometricFigure. All derived classes should 
                accept and display their respective attributes. All classes need to have the 
                capability to compute area of respective geometric figure. Member function 
                names in all classes need to be the same. (Hint: Use the concept of virtual 
                function) */


            // Base class reference
            GeometricFigure figure;

            Console.WriteLine("--- Rectangle ---");
            figure = new RectangleFigure();
            figure.Accept();
            figure.Display();
            Console.WriteLine("Area: " + figure.ComputeArea());

            Console.WriteLine("\n--- Square ---");
            figure = new SquareFigure();
            figure.Accept();
            figure.Display();
            Console.WriteLine("Area: " + figure.ComputeArea());

            Console.WriteLine("\n--- Circle ---");
            figure = new CircleFigure();
            figure.Accept();
            figure.Display();
            Console.WriteLine("Area: " + figure.ComputeArea());

            // Accessing via derived class reference
            Console.WriteLine("\n--- Accessing via derived class reference (Rectangle) ---");
            RectangleFigure rect = new RectangleFigure();
            rect.Accept();
            rect.Display();
            Console.WriteLine("Area: " + rect.ComputeArea());
        }
    }
}