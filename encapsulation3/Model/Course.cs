using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation3.Model
{
    public class Course
    {
        public string CourseName { get; set; }
        public static int StudentCount = 0;
        public const int MAX_AVAILABILITY = 3;

        public Course(string courseName)
        {
            CourseName = courseName;
        }
    }
}
