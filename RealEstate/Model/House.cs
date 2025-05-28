using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    // --- House class inherits Estate ---
    public class House : Estate
    {
        public double YardArea;
        public int Floors;
        public string IsFurnished;

        public House()
        {

        }

        public House(double area, string location, double yardArea, int floors, string isFurnished)
            : base(area, location)
        {
            YardArea = yardArea;
            Floors = floors;
            IsFurnished = isFurnished;
        }

     

            public override void DisplayDetails()
            {
                Console.WriteLine($"House - Area: {Area}, Price/sqm: , Location: {Location}, Undeveloped: , Yard: {YardArea}, Floors: {Floors}, Furnished: {IsFurnished}");
            }
        
    }
}
