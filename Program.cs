namespace PerfectNumberApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's perfect:");
            int numberToCheck;
            while (!int.TryParse(Console.ReadLine(), out numberToCheck))
            {
                Console.WriteLine("Please enter a valid integer number:");
            }

            var result = await IsPerfect(numberToCheck);
            Console.WriteLine(result);
        }

        public static async Task<string> IsPerfect(int num)
        {
            // will both divide exactly and the sum of the divisors will be equal to the divisor.
            var toplam = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"Divided by:{i}");
                    toplam = toplam + i;
                }
            }
            Console.WriteLine($"Sums of divisors:{toplam}");
            return toplam == num ? "The number is perfect" : "The number is not perfect";
        }
    }
}