namespace exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter employee age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18 || age > 60)
                {
                    throw new Exception("Age must be between 18 and 60.");
                }

                Console.WriteLine($"Employee Name: {name}, Age: {age}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
