using inheritence3.Model;

namespace inheritence3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Design a class Employee-no, Name, Designation, Basic Pay. Define a 
            derived class Executive whose Basic_pay is more than Rs.10,000. */

            //child class object instance 
            Executive executive = new Executive();
            executive.ReadData();
            executive.DisplayData();
        }
    }
}
