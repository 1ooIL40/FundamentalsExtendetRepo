namespace _01.Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class DayOfWeek
    {
        public static void Main()
        {
            var date = Console.ReadLine();

            var datTime = DateTime.ParseExact(date,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(datTime.DayOfWeek);
        }
    }
}
