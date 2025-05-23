namespace exception2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[10];

                // Initialize array with values
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = i + 1;
                }

                // Try to access the 11th element (index 10)
                Console.WriteLine("Accessing 11th element: " + numbers[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Tried to access an element outside the array bounds.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
        }
    }
}
