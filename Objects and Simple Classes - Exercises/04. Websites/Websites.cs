namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WebSite
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    public class Websites
    {
        public static void Main()
        {
            List<WebSite> webSite = new List<WebSite>();

            string[] inputLine = Console.ReadLine()
                .Split(" |,".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            while (inputLine[0] != "end")
            {
                string host = inputLine[0];
                string domain = inputLine[1];
                List<string> queries = inputLine
                    .Skip(2)
                    .ToList();

                WebSite newWebsite = new WebSite()
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                webSite.Add(newWebsite);

                inputLine = Console.ReadLine()
                .Split(" |,".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var website in webSite)
            {
                if (website.Queries.Count > 0)
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");

                    #region Print manually the queries
                    //Print manually the queries
                    for (int i = 0; i < website.Queries.Count; i++)
                    {
                        if(i < website.Queries.Count - 1)
                        {
                            Console.Write($"[{website.Queries[i]}]&");
                        }
                        else
                        {
                            Console.Write($"[{website.Queries[i]}]");
                        }
                    }
                    #endregion
                }
                else
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}");
                }
                Console.WriteLine();
            }
        }
    }
}
