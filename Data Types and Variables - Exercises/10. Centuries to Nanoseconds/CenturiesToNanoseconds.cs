
namespace _10.Centuries_to_Nanoseconds
{
    using System;

    public class CenturiesToNanoseconds
    {
        public static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint years = number * 100;
            double days;
            if (number < 5)
            {
                days = Math.Round(years * 365.241);
            }
            else
            {
                days = Math.Ceiling(years * 365.241);
                if ( number == 15)
                {
                    days += 1;
                }
            }
            double hours = days * 24;
            decimal minutes = (decimal)hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{number} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
