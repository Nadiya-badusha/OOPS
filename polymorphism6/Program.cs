using polymorphism6.Model;

namespace polymorphism6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Create a class Height with the following DataMembers 
                Identifier Type 
                Feet Int 
                Inches Int 
                Overload the + operator such that it should increase the value contained in the 
                Inches field by one and when the Inches value crosses 12 it should revert to 
                zero after increasing the Feet value by one. Display the output to the users*/

            Console.Write("Enter initial feet: ");
            int feet = int.Parse(Console.ReadLine());

            Console.Write("Enter initial inches: ");
            int inches = int.Parse(Console.ReadLine());

            Height height = new Height(feet, inches);

            Console.WriteLine("\nOriginal Height:");
            height.Display();

            // Increase inches by 1 using overloaded + operator
            height = height + 1;

            Console.WriteLine("\nAfter incrementing 1 inch:");
            height.Display();
        }
    }
    }

