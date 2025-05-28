using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    public class Company
    {
        public string companyName;
        public string Owner;
        public string TaxID;
        

      
            
            public List<Employee> Employees { get; set; } = new();
            public List<Estate> Estates { get; set; } = new();
       
        public void ShowCompanyInfo()
        {
            Console.WriteLine($"\n--- {companyName} ---");
            Console.WriteLine($"Owner: {Owner} | Tax ID: {TaxID}");

           
        }
    }
}
