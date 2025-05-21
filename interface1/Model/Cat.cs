using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1.Model
{
    public class Cat:Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Cats Say Meoow");
        }
    }
}
