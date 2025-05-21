using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_4.Model
{
    public class Student
    {
        public string Name;
        public int StudentID;
        public string Major; // "Graduate" or "Post Graduate"

        public Student(string name, int studentId, string major)
        {
            Name = name;
            StudentID = studentId;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} (ID: {StudentID}) is studying. Program: {Major}");
        }
    }
}
