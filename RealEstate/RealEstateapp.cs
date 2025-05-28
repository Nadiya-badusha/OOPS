using System.Diagnostics;
using System.Xml.Linq;
using System;
using RealEstate.Model;
using RealEstate.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.Design;
using System.Drawing;

namespace RealEstate
{
    public class Program
    {
        //company object intiaization
        static Company company = new Company();

        static void Main(string[] args)
        {
            //input company details
            Console.WriteLine("=== Real Estate Company Management System ===");
        lblcompanyName:
            Console.Write("Enter company name: ");
            company.companyName = Console.ReadLine();

            bool IsValidInputName = CustomValidation.IsValidaName(company.companyName);
            if (!IsValidInputName)
            {
                goto lblcompanyName;
            }

        lblowner:
            Console.Write("Enter owner name: ");
            company.Owner = Console.ReadLine();
            bool IsValidowner = CustomValidation.IsValidaName(company.Owner);
            if (!IsValidowner)
            {
                goto lblowner;
            }
        lbltaxid:
            Console.Write("Enter tax ID: ");
            company.TaxID = Console.ReadLine();
            bool IsValidtaxid = CustomValidation.IsValidNumber(company.TaxID);
            if (!IsValidtaxid)
            {
                goto lbltaxid;
            }



            //menu driven
            while (true)
            {
                Console.WriteLine($"\n{company.companyName} Main Menu");
                Console.WriteLine("1. Manage Employees");
                Console.WriteLine("2. Manage Estates");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ManageEmployees();
                        break;
                    case "2":
                        ManageEstates();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //employee menu driven
        static void ManageEmployees()
        {
            while (true)
            {
                Console.WriteLine("=== Employee Management ===");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. List Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();


                //add employee 
                //input employee details
                if (choice == "1")
                {
                    var emp = new Employee();
                lblempname:
                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();
                    bool IsValidempname = CustomValidation.IsValidaName(emp.Name);
                    if (!IsValidempname)
                    {
                        goto lblempname;
                    }
                lblposition:
                    Console.Write("Position: ");
                    emp.Position = Console.ReadLine();
                    bool IsValidposition = CustomValidation.IsValidaName(emp.Position);
                    if (!IsValidposition)
                    {
                        goto lblposition;
                    }

                
                    Console.Write("Experience (years): ");
                    emp.Experience = int.Parse(Console.ReadLine());
                    
                    company.Employees.Add(emp);
                    Console.WriteLine("Employee added.");

                }

                //list employee
                else if (choice == "2")
                {
                    foreach (var emp in company.Employees)
                    {
                        Console.WriteLine($"{emp.Name}, {emp.Position}, {emp.Experience} yrs");
                    }
                }

                //update employee
                else if (choice == "3")
                {
                    Console.Write("Enter employee name to update: ");
                    var name = Console.ReadLine();
                    var emp = company.Employees.Find(e => e.Name == name);
                    if (emp != null)
                    {
                        Console.Write("New Position: ");
                        emp.Position = Console.ReadLine();
                        Console.Write("New Experience: ");
                        emp.Experience = int.Parse(Console.ReadLine());
                        Console.WriteLine("Updated.");
                    }
                    else Console.WriteLine("Not found.");
                }

                //delete employee
                else if (choice == "4")
                {
                    Console.Write("Enter name to delete: ");
                    var name = Console.ReadLine();
                    company.Employees.RemoveAll(e => e.Name == name);
                    Console.WriteLine("Deleted if existed.");
                }

                //exit
                else if (choice == "5")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("invaild choice");
                    Console.ReadKey();
                    continue;
                }

            }
        }


        //estate menu driven
        static void ManageEstates()
        {
            while (true)
            {
                Console.WriteLine("=== Estate Management ===");
                Console.WriteLine("1. Add Estate");
                Console.WriteLine("2. List Estates");
                Console.WriteLine("3. Delete Estate by Location");
                Console.WriteLine("4. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Select Estate Type:\n1.Apartment\n2.House\n3.Undeveloped Land\n4.Shop");
                    var type = Console.ReadLine();
                    Estate estate = null;

                    Console.Write("Area: ");
                    double area = double.Parse(Console.ReadLine());
                    Console.Write("Price/sqm: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Location: ");
                    string location = Console.ReadLine();

                    switch (type)
                    {
                        case "1":
                           
                            Console.Write("Floor: ");
                            int Floor = int.Parse(Console.ReadLine());
                            Console.Write("Has Elevator (y/n): ");
                            string HasElevator = Console.ReadLine();
                            Console.Write("Is Furnished (y/n): ");
                            string IsFurnished = Console.ReadLine();

                            estate=new Apartment(area,location,Floor,HasElevator,IsFurnished);

                            break;
                        case "2":
                            Console.Write("Floor: ");
                            int levels = int.Parse(Console.ReadLine());
                            Console.Write("Yard area ");
                            double yardarea = int.Parse(Console.ReadLine());
                            Console.Write("Is Furnished (y/n): ");
                            string furnished = Console.ReadLine();

                            estate =new House(area,location,yardarea,levels,furnished);



                            break;
                        case "3":
                            estate = new UndevelopedArea(area, location);
                            break;
                        case "4":
                            estate = new Shop(area, location);
                            break;
                    }

                    if (estate != null)
                    {
                        company.Estates.Add(estate);
                        Console.WriteLine("Estate added.");
                    }
                }
                else if (choice == "2")
                {
                    foreach (var est in company.Estates)
                        est.DisplayDetails();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter location to delete: ");
                    var loc = Console.ReadLine();
                    company.Estates.RemoveAll(e => e.Location == loc);
                    Console.WriteLine("Estate(s) deleted if existed.");
                }
                else break;

                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }

    }
}








 
