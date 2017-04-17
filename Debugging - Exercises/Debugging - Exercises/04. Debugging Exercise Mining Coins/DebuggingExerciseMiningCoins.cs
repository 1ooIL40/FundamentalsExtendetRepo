
namespace _04.Debugging_Exercise_Mining_Coins
{
    using System;

    public class DebuggingExerciseMiningCoins
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number / 100;
                int middleDigit = (number % 100) / 10;
                int lastDigit = number % 10;

                totalValue += (firstDigit + middleDigit + lastDigit) / (float)n;
                int asciiCode = 0;

                if (i % 2 == 1)
                {
                    asciiCode = ((firstDigit * 10) + lastDigit) - middleDigit;
                }
                else
                {
                    asciiCode = ((firstDigit * 10) + lastDigit) + middleDigit;
                }

                if ((asciiCode >= 65 && asciiCode <= 90)
                    || (asciiCode >= 97 && asciiCode <= 122))
                {
                    decrypted += (char)asciiCode;
                }
            }
            
            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);

        }
    }
}
