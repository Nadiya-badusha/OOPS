using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstate.Model
{
    // --- Apartment class inherits Estate ---
    public class Apartment :Estate
    {
        

        
        public int Floor;
        public string HasElevator;
        public string IsFurnished;

        public Apartment()
        {

        }
        public Apartment(double area, string location, int floor, string hasElevator, string isFurnished)
            : base(area, location)
        {
            Floor = floor;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Apartment - Area: {Area}, Price/sqm: , Location: {Location}, Floor: {Floor}, Elevator: {HasElevator}, Furnished: {IsFurnished}");
        }
        
    }
}
