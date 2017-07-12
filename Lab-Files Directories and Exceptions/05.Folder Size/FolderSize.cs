namespace _05.Folder_Size
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            string[] filesInDirectory = Directory.GetFiles("../../TestFolder");
            double sum = 0;

            foreach (var file in filesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = (sum / 1024 / 1024);

            File.WriteAllText("../../output.txt", sum.ToString());
        }
    }
}
