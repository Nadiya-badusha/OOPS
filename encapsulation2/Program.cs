using Encapsulation2.Model;

namespace Encapsulation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Develop a ConsoleApp to enter Order Details using properties 
            in a simplified inventory system. The application allows users 
            to input order information such as :-   
 
            • Order Id 
            • Date 
            • Customer ID 
            • Product ID 
            • Product Name 
            • Quantity 
            • Rate 
 
            The application also provides a list of available Product IDs 
            along with their corresponding product names for selection. */





            Console.WriteLine("=== Welcome to Inventory System ===\n");
            while (true)
            {
                Order order = new Order();

                // Input Order ID


                bool validatorderid = false;
                while (!validatorderid)
                {
                    Console.Write("Enter Order ID: ");
                    order.OrderId = Console.ReadLine();
                    //condition check
                    if (int.TryParse(order.OrderId, out int orderId) && orderId > 0)
                    {
                        validatorderid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid! Enter a valid number");
                    }
                }


                // Input Date
                order.Date = DateTime.Now;

                // Input Customer ID

                bool validatcustid = false;
                while (!validatcustid)
                {
                    Console.Write("Enter Customer ID: ");
                    order.CustomerId = Console.ReadLine();
                    //condition check
                    if (int.TryParse(order.CustomerId, out int customerid) && customerid > 0)
                    {
                        validatcustid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid! Enter a valid number");
                    }
                }






                // Show available products
                Console.WriteLine("\nAvailable Products:");
                Console.WriteLine("\"P101\"  \"Laptop\" \n\"P102\"  \"Smartphone\" \n\"P103\"  \"Headphones\" ");

                // Input Product ID
                while (true)
                {
                    Console.Write("\nEnter Product ID from above list: ");
                    string pid = Console.ReadLine();
                    if (pid == "P101")
                    {
                        order.ProductId = "P101";
                        order.ProductName = "Laptop";
                        break;
                    }
                    else if (pid == "P102")
                    {
                        order.ProductId = "P102";
                        order.ProductName = "Smartphone";
                        break;
                    }
                    else if (pid == "P103")
                    {
                        order.ProductId = "P103";
                        order.ProductName = "Headphone";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                }
                        // Input Quantity

                        bool validatquant = false;
                    while (!validatquant)
                    {
                        Console.Write("Enter Quantity: ");
                        order.Quantity = Console.ReadLine();

                        //condition check
                        if (int.TryParse(order.Quantity, out int quantity) && quantity > 0)
                        {
                            validatquant = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid! Enter a valid number");
                        }
                    }


                    // Input Rate

                    bool validatrate = false;
                    while (!validatrate)
                    {

                        Console.Write("Enter Rate per item: ");
                        order.Rate = Console.ReadLine();

                        //condition check
                        if (int.TryParse(order.Rate, out int rate) && rate > 0)
                        {
                            validatquant = true;
                        break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid! Enter a valid number");
                        }
                    }


                    // Display Order Summary
                    order.DisplayOrder();

                    Console.WriteLine("Do you want to continue (y/n)");
                    char option = Convert.ToChar(Console.ReadLine());
                    if (char.ToLower(option) == 'n')
                    {
                        Console.WriteLine("Thank you for using the app");
                        break;
                    }
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }

