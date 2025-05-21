using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1.Model
{
    public class Bank
    {
        private string _acnumber;
        private string _acholdername;
        private string _actype;
        private double _acbalance;
        private double _acminbalance;
            
        public string AcNumber
        {
            get { return _acnumber; }
            set { _acnumber = value; }

        }


        public string AcHolderName { get {return _acholdername; } set { _acholdername = value; } }

        public string AcType { get { return _actype; } set { _actype = value; } }

        public double AcBalance { get { return _acbalance; } set { _acbalance = value; } }


        public double AcMinBalance { get { return _acminbalance; } set { _acminbalance = value; } }

        int AccNumber;


        public void AddCustomer()
        {
            bool validatenumber = false;
            while (!validatenumber)
            {
                //acnumber
                Console.Write("Enter Account number: ");
                AcNumber = Console.ReadLine();

                //condition check
                if (int.TryParse(AcNumber, out AccNumber) && AccNumber > 0)
                {
                    validatenumber = true;
                }
                else
                {
                    Console.WriteLine("Invalid! Enter a valid number");
                }
            }




            //acholdername

            Console.WriteLine("Enter Account Holder name: ");
            AcHolderName = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(AcHolderName)

                || AcHolderName.StartsWith(" ")
                || !AcHolderName.All(char.IsLetter)
                )
            {
                Console.WriteLine("Invaild!");
                Console.Write("Enter Name : ");
                AcHolderName = Console.ReadLine();
            }
           



            //acctype
            Console.Write("Enter Account type: ");
            AcType = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(AcType)

                || AcType.StartsWith(" ")
                || !AcType.All(char.IsLetter)
                )
            {
                Console.WriteLine("Invaild!");
                Console.Write("Enter TYPE: ");
                AcType = Console.ReadLine();
            }


            bool validateminbal = false;
            while (!validateminbal)
            {
                //accminbalance
                Console.Write("Enter Account minimunm Balance: ");
                AcMinBalance = Convert.ToDouble(Console.ReadLine());
                if (AcMinBalance > 0)
                {
                    validateminbal = true;
                }
                else
                {
                    Console.WriteLine("Invalid! Enter a valid");
                }
            }

            //accbalance
            bool validatebal = false;
            while (!validatebal)
            {
                Console.Write("Enter Account Balance: ");
                AcBalance = Convert.ToDouble(Console.ReadLine());
                if (AcBalance >0)
                {
                    validatebal = true;
                }
                else
                {
                    Console.WriteLine("Invalid! Enter a valid ");
                }
            }

            

        }



        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\n---------------------------------Customer Details ---------------------------");
            Console.WriteLine("Account number                  :" + AcNumber);
            Console.WriteLine("Account Holder Name             :" + AcHolderName);
            Console.WriteLine("Account type                    :" + AcType);
            Console.WriteLine("Account Balance                 :" + AcBalance);
            Console.WriteLine("---------------------------------------------------------------------------");

        }

    }
}
