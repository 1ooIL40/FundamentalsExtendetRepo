
namespace Demos
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            //PrintReceipt();

            //var num = 4;
            //var numSquared = GetSquare(num);
            //Console.WriteLine(numSquared);

            //PrintNumbers(2, 5);

            //PrintStudent("Pesho", 15, 5.60);

            //var n = int.Parse(Console.ReadLine());
            //PrintSigh(n);

            //PrintNumber(0, 100);
            //PrintNumber(15);
            //PrintNumber();
            //PrintNumber(end: 50, start: 20);

            //var n = int.Parse(Console.ReadLine());
            //PrintTriangle(n);

            //var n = int.Parse(Console.ReadLine());
            //PrintFilledSquare(n);

            //var fahrenheit = double.Parse(Console.ReadLine());
            //var celsius = ConvertFromFahrenheitToCelsius(fahrenheit);
            //Console.WriteLine(celsius);

            //var width = double.Parse(Console.ReadLine());
            //var height = double.Parse(Console.ReadLine());

            //var triangleArea = CalculateArea(width, height);

            //Console.WriteLine(triangleArea);

            //var number = double.Parse(Console.ReadLine());
            //var power = int.Parse(Console.ReadLine());

            //var numberRaisedToPower = RaseToPower(number, power);

            //Console.WriteLine(numberRaisedToPower);

            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var value1 = int.Parse(Console.ReadLine());
                        var value2 = int.Parse(Console.ReadLine());
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                    }
                    break;
                case "char":
                    {

                        var value1 = char.Parse(Console.ReadLine());
                        var value2 = char.Parse(Console.ReadLine());
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                    }
                    break;
                case "string":
                    {
                        var value1 = Console.ReadLine();
                        var value2 = Console.ReadLine();
                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                    }
                    break;
            }
        }

        static object Max(int int1, int int2)
        {
            if (int1 > int2)
            {
                return int1;
            }

            return int2;
        }

        static char Max(char char1,char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }
        static string Max(string str1, string str2)
        {
            if ( str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            return str2;
        }

        static double RaseToPower(double num, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }

        static object CalculateArea(double width, double height)
        {
            var area = (width * height) / 2;
            return area;
        }

        static double ConvertFromFahrenheitToCelsius(double fahrenheit)
        {
            var converted = (fahrenheit - 32) * 5 / 9;
            return converted;
        }

        static void PrintFilledSquare(int n)
        {
            PrintContures(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintContures(n);
        }

        static void PrintMiddle(int n)
        {
            var mid = $"-";

            for (int i = 0; i < n - 1; i++)
            {
                mid += "\\/";
            }
            mid += "-";
            Console.WriteLine(mid);
        }

        static void PrintContures(int n)
        {
            var contur = new string('-', n * 2);
            Console.WriteLine(contur);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void PrintNumber(int start = 1, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintSigh(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }

        static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine($"Student: {name}; Age: {age}; Grade: {grade:f2}");
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static double GetSquare(double number)
        {
            var result = number * number;
            return result;
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

    }
}
