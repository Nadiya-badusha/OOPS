using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    public class UndevelopedArea : Estate
    {
        public UndevelopedArea(double area, string location)
            : base(area, location)
        {
        }

       
            public override void DisplayDetails()
            {
                Console.WriteLine($"Undeveloped Land - Area: {Area}, Price/sqm: , Location: {Location}");
            }
        
    }
}
