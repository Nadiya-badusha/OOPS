using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    // --- Shop ---
    public class Shop : Estate
    {
        public Shop(double area, string location)
            : base(area,  location)
        {
        }

        
            public override void DisplayDetails()
            {
                Console.WriteLine($"Shop - Area: {Area}, Price/sqm: , Location: {Location}");
            }
        
    }

}
