 using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism2.Math
{

    public class Mathop


    {


        // Add method - overloaded
        public int Add(int firstnum, int secondnum)
        {
            return firstnum + secondnum;
        }
        public double Add(double firstnum, double secondnum)
        {
            return firstnum + secondnum;
        }

        // Subtract method - overloaded
        public int Subtract(int firstnum, int secondnum)
        {
            return firstnum - secondnum;
        }
        public double Subtract(double firstnum, double secondnum)
        {
            return firstnum - secondnum;
        }

        // Multiply method - overloaded
        public int Multiply(int firstnum, int secondnum)
        {
            return firstnum * secondnum;
        } 
        public double Multiply(double firstnum, double secondnum)
        {
            return firstnum * secondnum;
        } 

        // Divide method - overloaded
        public int Divide(int firstnum, int secondnum)
        {
            return (firstnum / secondnum);
        }
        public double Divide(double firstnum, double secondnum)
        {
            return (firstnum / secondnum);
        }
    }
}