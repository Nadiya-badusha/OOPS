using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation3.Model;

namespace Encapsulation3.Model
{    
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EnrolledCourse { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void EnrollCourse(Course course)
        {
            if (Course.StudentCount >= Course.MAX_AVAILABILITY)
            {
                Console.WriteLine($"Enrollment failed for {Name}. Course '{course.CourseName}' is full.");
            }
            else
            {
                EnrolledCourse = course.CourseName;
                Course.StudentCount++;
                Console.WriteLine($"{Name} (ID: {ID}) successfully enrolled in '{course.CourseName}'.");
            }
        }
    }
}

