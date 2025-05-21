using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence1.Model
{
    public class Student:Person
    {
        public int Roll { get; set; }
        public int Marks { get; set; }


        //method
        public void Get_Data()
        {
            Read_Data();
            Console.Write("Enter Roll No: ");
            Roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks: ");
            Marks = Convert.ToInt32(Console.ReadLine());
        }


        //method
        public string Compute_Grade()
        {
            if (Marks >= 90)
                return "A";
            else if (Marks >= 75)
                return "B";
            else if (Marks >= 50)
                return "C";
            else
                return "Fail";
        }

        //method
        public void Show_Data()
        {
            Display_Data();
            Console.WriteLine($"Roll: {Roll}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Grade: {Compute_Grade()}");
        }
    }
}
