using inheritence_4.Model;

namespace inheritence_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             Design classes for the entities Student, Professor and Course. The 
            Student has the attributes Name, Student ID and Major.   Major attribute 
            should differentiate between Graduate and Post Graduate Student. 
            Design Professor class with attributes Name, EmpID and Major. The 
            Course class includes title and duration (single subject).Incorporate 
            appropriate getter and setter methods. Also define method study() and 
            teach () in the respective classes.*/


            // Input for Course
            Console.Write("Enter Course Title: ");
            string courseTitle = Console.ReadLine();
            Console.Write("Enter Course Duration (in hours): ");
            int courseDuration = Convert.ToInt32(Console.ReadLine());
            //course obj creation
            Course course = new Course(courseTitle, courseDuration);
            course.DisplayCourse();

            // Input for Student
            Console.Write("\nEnter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Major (Graduate/Post Graduate): ");
            string studentMajor = Console.ReadLine();

            //student obj creation
            Student student = new Student(studentName, studentId, studentMajor);
            student.Study();

            // Input for Professor
            Console.Write("\nEnter Professor Name: ");
            string professorName = Console.ReadLine();
            Console.Write("Enter Professor Employee ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Professor's Major: ");
            string professorMajor = Console.ReadLine();

            //professor object creation
            Professor professor = new Professor(professorName, empId, professorMajor);
            professor.Teach();

            Console.WriteLine("\nAll data recorded successfully.");
        }


    }
    }

