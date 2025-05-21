using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2.Model
{
    public class Order
    {

        private string _id;
        private string _custid;
        private DateTime _date;
        private string _productid;
        private string _productname;
        private string _quantity;
        private string _rate;

            public string OrderId { get { return _id; } set { _id = value; } }
            public DateTime Date { get;  set; }
            public string CustomerId { get { return _custid; } set { _custid = value; } }
            public string ProductId { get { return _productid; } set { _productid = value; } }
            public string ProductName { get { return _productname; } set { _productname = value; } }
            public string Quantity { get { return _quantity; } set { _quantity = value; } }
            public string Rate { get { return _rate; } set { _rate = value; } }

            public double TotalAmount => Convert.ToInt32(Quantity) * Convert.ToDouble(Rate);

            public void DisplayOrder()
            {
                Console.WriteLine("\n------ Order Details ------");
                Console.WriteLine($"Order ID     : {OrderId}");
                Console.WriteLine($"Date         : {Date.ToShortDateString()}");
                Console.WriteLine($"Customer ID  : {CustomerId}");
                Console.WriteLine($"Product ID   : {ProductId}");
                Console.WriteLine($"Product Name : {ProductName}");
                Console.WriteLine($"Quantity     : {Quantity}");
                Console.WriteLine($"Rate         : {Rate:C}");
                Console.WriteLine($"Total Amount : {TotalAmount:C}");
                Console.WriteLine("---------------------------\n");
            }
        }
}
