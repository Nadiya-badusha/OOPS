using inheritence1.Model;

namespace inheritence1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The class inheritance diagram is given below. 
            Person 
            Name 
            Age 
            Read_data 
            Display_Data 



            Student 
            Roll 
            Marks 
            Get_data 
            Compute_grade 
            Show_Data 

            Employee 
            BP 
            HR 
            Sal 
            Get_data 
            Compute_Sal*/


            //creating student object and printing
            Console.WriteLine("welcome");
            Console.WriteLine("--- Student Details ---");
            Student student = new Student();
            student.Get_Data();
            student.Show_Data();


            //creating employee object and printing
            Console.WriteLine("\n--- Employee Details ---");
            Employee employee = new Employee();
            employee.Get_Data();
            employee.Compute_Sal();
            employee.Show_Data();
        }
    }
}
