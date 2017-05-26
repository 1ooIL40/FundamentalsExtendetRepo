namespace _01.Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class RegisterUsers
    {
        public static void Main()
        {
            var userAndDateRegistered = Console.ReadLine();
            var userRegistration = new Dictionary<string, DateTimeOffset>();

            while (userAndDateRegistered != "end")
            {
                var nameAndData = userAndDateRegistered
                    .Split(" ->".ToArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                var name = nameAndData[0];
                var date = DateTime.ParseExact(nameAndData[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!userRegistration.ContainsKey(name))
                {
                    userRegistration[name] = new DateTimeOffset();
                }
                userRegistration[name] = date;
                userAndDateRegistered = Console.ReadLine();
            }

            var orderedRegister = userRegistration
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var ordered in orderedRegister)
            {
                Console.WriteLine(ordered.Key);
            }
        }
    }
}
