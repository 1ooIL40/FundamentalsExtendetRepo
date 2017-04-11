
namespace _11.Convert_Speed_Units
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int oneMile = 1609; // 1 mile = 1609 meters.
            int hoursInMinutes = hours * 60;
            int hoursInSeconds = hoursInMinutes * 60;
            int minutesInSeconds = minutes * 60;
            int time =(hoursInSeconds + minutesInSeconds + seconds);

            float distancePerSeconds = (float)distance / time;
            float distancePerKilometers = ((float)distance / 1000) / ((float)time / 3600);
            float distancePerMile = ((float)distance / oneMile) / ((float)time / 3600);

            Console.WriteLine($"{distancePerSeconds}");
            Console.WriteLine($"{distancePerKilometers}");
            Console.WriteLine($"{distancePerMile}");
        }
    }
}
