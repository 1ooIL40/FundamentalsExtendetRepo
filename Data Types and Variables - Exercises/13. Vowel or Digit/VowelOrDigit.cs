
namespace _13.Vowel_or_Digit
{
    using System;

    public class VowelOrDigit
    {
        public static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            
            if(symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'u' || symbol == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(symbol))
            {
                Console.WriteLine("digit");
            }       
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
