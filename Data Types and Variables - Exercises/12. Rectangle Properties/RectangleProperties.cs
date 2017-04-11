
namespace _12.Rectangle_Properties
{
    using System;

    public class RectangleProperties
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);

            double perimeter = 2 * a + 2 * b;
            double area = a * b;
            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine(c);
        }
    }
}
