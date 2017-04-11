
namespace _05.Refactor_Special_Numbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0; int takova = 0; bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine($"{takova} -> {toe}");
            //    obshto = 0;
            //    ch = takova;
            //}

            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                var sum = 0;
                var currentNumber = i;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                var resul = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {resul}");
            }
        }
    }
}
