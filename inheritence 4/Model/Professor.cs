using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_4.Model
{
    public class Professor
    {
        public string Name;
        public int EmpID;
        public string Major;

        public Professor(string name, int empId, string major)
        {
            Name = name;
            EmpID = empId;
            Major = major;
        }

        public void Teach()
        {
            Console.WriteLine($"Professor {Name} (EmpID: {EmpID}) is teaching {Major}.");
        }
    }
}
