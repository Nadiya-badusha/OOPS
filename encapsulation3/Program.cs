using Encapsulation3.Model;  

namespace Encapsulation3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a class Student which contains the properties such as 
                ID,name and course. Add a method in the Student class 
                named EnrollCourse.  Modify the Course class to hold a static 
                variable that contains the number of Students enrolled and 
                MAX_AVAILABILITY. When a Student is trying to enroll for a 
                course it has to check whether it reaches the maximum  
                availability then show error message.*/



            Course course = new Course("Computer Science");

            Console.WriteLine("Course enrollment system (Max Seats = 3)\n");

            for (int i = 0; i < 5; i++) // Trying to enroll 5 students, only 3 allowed
            {
                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Student student = new Student(id, name);
                student.EnrollCourse(course);

                Console.WriteLine(); // Spacer
            }

            Console.WriteLine("\nEnrollment attempt complete.");
        }
    }    
    }
    

