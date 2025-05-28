using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    public class Estate
    {
        
        public double Area;
        public double PricePerSqm;
        public string Location;
        public string Type;
        public string ExtraInfo;
        
           
        public Estate

            () { }
        public Estate(double area, string location)
        {


            Area = area;
            //PricePerSqm = pricePerSqm;
            Location = location;
        }

        public Estate(double area, double pricePerSqm, string location, string type, string extraInfo)
        {
            Area = area;
            PricePerSqm = pricePerSqm;
            Location = location;
            Type = type;
            ExtraInfo = extraInfo;
        }
        public virtual void DisplayDetails(){
            Console.WriteLine();
        }
        
    }
}
