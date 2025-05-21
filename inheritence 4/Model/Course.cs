using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_4.Model
{
    public class Course
    {
        public string Title;
        public int Duration; // in hours or weeks

        public Course(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public void DisplayCourse()
        {
            Console.WriteLine($"\nCourse: {Title}, Duration: {Duration} hours");
        }
    }
}
