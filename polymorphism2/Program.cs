using polymorphism2.Math;

namespace polymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*  Design a class Math consists of the methods   add (), subtract (), multiply () 
                and divide () operations which will return the respective values. Design an 
                interface which will call the methods. */


            //object creation
            Mathop maths = new Mathop();


            while (true)
            {
                Console.WriteLine("\nEnter first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an option:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
                int option = Convert.ToInt32(Console.ReadLine());

               
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Result: " + maths.Add(firstNumber, secondNumber));
                            break;
                        case 2:
                            Console.WriteLine("Result: " + maths.Subtract(firstNumber, secondNumber));
                            break;
                        case 3:
                            Console.WriteLine("Result: " + maths.Multiply(firstNumber, secondNumber));
                            break;
                        case 4:
                            Console.WriteLine("Result: " + maths.Divide(firstNumber, secondNumber));
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                


                Console.WriteLine("Do you want to continue (y/n)");
                char select = Convert.ToChar(Console.ReadLine());
                if (char.ToLower(select) == 'n')
                {
                    Console.WriteLine("Thank you for using the app");
                    break;
                }
            }
        }
    }
}


