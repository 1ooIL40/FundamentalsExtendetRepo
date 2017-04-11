
namespace _19.Thea_The_Photographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            int amauntOfPickters = int.Parse(Console.ReadLine());
            int requiredFilterTime = int.Parse(Console.ReadLine()); // in seconds
            int percentGoodPicks = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine()); // in seconds

            double percent = (double)percentGoodPicks / 100.0;
            int totalPicks = (int)Math.Ceiling(amauntOfPickters * percent);
            long fullTime = amauntOfPickters * (long)requiredFilterTime;
            long totalUploadTime = totalPicks * (long)uploadTime;

            long totalTimeNeeed = fullTime + totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeNeeed);

            Console.WriteLine(time.ToString(new string ('d',1)+@"\:hh\:mm\:ss"));
        }
    }
}
