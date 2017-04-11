
namespace _16.Comparing_floats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double abs = Math.Abs(numberA - numberB);
            bool diff = true;

            if(abs > eps)
            {
                diff = false;
            }
            
            Console.WriteLine(diff);

        }
    }
}
