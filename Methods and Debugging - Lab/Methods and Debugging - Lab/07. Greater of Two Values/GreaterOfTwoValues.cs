
namespace _07.Greater_of_Two_Values
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            GetMax(input);
        }

        static void GetMax(string type)
        {
            switch (type)
            {
                case "string":
                    {
                        var valueOne = Console.ReadLine();
                        var valueTwo = Console.ReadLine();

                        var greater = GreaterOfTwo(valueOne, valueTwo);
                        Console.WriteLine(greater);
                    }
                    break;
                case "char":
                    {
                        var valueOne = char.Parse(Console.ReadLine());
                        var valueTwo = char.Parse(Console.ReadLine());

                        var greater = GreaterOfTwo(valueOne, valueTwo);
                        Console.WriteLine(greater);
                    }
                    break;
                case "int":
                    {
                        var valueOne = int.Parse(Console.ReadLine());
                        var valueTwo = int.Parse(Console.ReadLine());

                        var greater = GreaterOfTwo(valueOne, valueTwo);
                        Console.WriteLine(greater);
                    }
                    break;
            }
        }
        static char GreaterOfTwo(char valueOne, char valueTwo)
        {
            if (valueOne >= valueTwo)
            {
                return valueOne;
            }
            return valueTwo;
        }

        static string GreaterOfTwo(string valueOne, string valueTwo)
        {
            var result = valueOne.CompareTo(valueTwo);
            
            if (valueOne.CompareTo(valueTwo) >= 0)
            {
                return valueOne;
            }
            return valueTwo;
        }

        static int GreaterOfTwo(int valueOne, int valueTwo)
        {
            if (valueOne > valueTwo)
            {
                return valueOne;
            }

            return valueTwo;
        }
    }
}
