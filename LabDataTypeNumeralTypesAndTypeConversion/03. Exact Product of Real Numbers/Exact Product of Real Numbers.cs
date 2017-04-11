using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal numbers = 0m;
            decimal product = 1m;
            for (int i = 0; i < n; i++)
            {
                numbers = decimal.Parse(Console.ReadLine());
                product *= numbers;
            }
            Console.WriteLine($"{product}");
        }
    }
}
