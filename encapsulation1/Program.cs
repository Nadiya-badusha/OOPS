using System.Xml.Serialization;
using Encapsulation1.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace encapsulation1
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            Design a class in C# that represents a bank Account with  
            the data members/Fields.

            Use appropriate modifiers with data members and methods.

            Identifier             Type ---------                 ---- 
            AcNumber Integer
            AcHolderName String
            AcBalance Double
            AcType String
            AcMinBalance Double


            Functionalities: Add Customer details, Display customer
            Zetails and Show account balance.Implement the properties
            for the appropriate members of the class.*/


            Console.WriteLine("Welcome to Bank");

            while (true)
            {
                    //add customer
                    Bank customer = new Bank();
                    customer.AddCustomer();

                    customer.DisplayCustomerDetails();

               
                
                    Console.WriteLine("Do you want to continue (y/n)");
                    char option = Convert.ToChar(Console.ReadLine());
                if (char.ToLower(option) == 'n')
                {
                    Console.WriteLine("Thank you for using the app");
                    break;
                }

            }

            //pause key
            Console.WriteLine("Press any key to exit");
                Console.ReadKey();









        }
    }
}
