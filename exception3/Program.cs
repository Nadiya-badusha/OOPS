namespace exception3
{
    internal class Program
    {
        // Method to generate random number and check for prime
        static int GetRandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(1, 100);  // Random number between 1 and 99

            if (IsPrime(number))
            {
                throw new Exception($"Generated number {number} is a prime number.");
            }

            return number;
        }

        // Helper method to check if a number is prime
        static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            try
            {
                int result = GetRandomNumber();
                Console.WriteLine($"Generated number is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
