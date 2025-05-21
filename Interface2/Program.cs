using Interface2.Model;

namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nChoose interface to test:\n1. IFirst\n2. ISecond");
            Console.Write("Enter your choice (1 or 2): ");
            string interfaceChoice = Console.ReadLine();

            Numbers num = new Numbers();

            Console.WriteLine();
            switch (interfaceChoice)
            {
                case "1":
                    Ifirst choice = num;
                    choice.Display();
                    choice.GetValue();
                    break;

                case "2":
                    Isecond select = num;
                    select.Display();
                    select.Demo();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }
}
