using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Model
{
    public class Numbers : Ifirst, Isecond
    {
        // Explicit implementation of Display for IFirst
        void Ifirst.Display()
        {
            Console.WriteLine("IFirst Display Implementation");
        }

        // Explicit implementation of Display for ISecond
        void Isecond.Display()
        {
            Console.WriteLine("ISecond Display Implementation");
        }
        // Public implementation for GetValue
        public void GetValue()
        {
            Console.WriteLine("IFirst GetValue Implementation");
        }

        // Public implementation for Demo
        public void Demo()
        {
            Console.WriteLine("ISecond Demo Implementation");
        }
    }
    }
