using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double course = Math.Ceiling((double)n / (4 + 8 + 12));
            Console.WriteLine(course);
        }
    }
}
