
namespace _15.Fast_Prime_Checker
{
    using System;

    public class FastPrimeChecker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;
                double square = Math.Sqrt(number);
                for (int check = 2; check <= square; check++)
                {
                    if(number % check == 0)
                        {
                            isPrime = false;
                            break;
                        }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }
        }
    }
}
