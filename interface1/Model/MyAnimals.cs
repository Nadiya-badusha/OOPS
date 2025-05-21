using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1.Model
{
    public class MyAnimals:Animals,Imammals
    {
        public int BodyTemp { get; set; }
        public int GetBodyTemp(string bodytemp)
        {
            Console.WriteLine($"The body temp is {bodytemp} ");
            return BodyTemp;

        }

        public override void SaySomething()
        {
            Console.WriteLine("Hi! I am a mammal and I can speak.");
        }
    }
}
