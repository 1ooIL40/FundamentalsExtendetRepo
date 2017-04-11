
namespace _07.Exchange_Variable_Values
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            a = b;
            b = c;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
