namespace _02.Ordered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main(string[] args)
        {
            var userInput = Console.ReadLine();

            var userBankInformation = new Dictionary<string, Dictionary<string, decimal>>();

            userBankInformation = AddUserDataInput(userInput, userBankInformation);

            userBankInformation
                .OrderByDescending(bank => bank.Value.Sum(accuont => accuont.Value))
                .ThenByDescending(bank => bank.Value.Max(accuont => accuont.Value))
                .ToList()
                .ForEach(bank => bank.Value
                    .OrderByDescending(account => account.Value)
                    .ToList()
                    .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));



        }
        #region UserInputToDictionary
        static Dictionary<string, Dictionary<string, decimal>> AddUserDataInput(string userInput, Dictionary<string, Dictionary<string, decimal>> userBankInformation)
        {
            while (userInput != "end")
            {
                //split the data and take it as we need it
                var dataInput = userInput
                    .Split(" ->".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var bankName = dataInput[0];
                var userAccount = dataInput[1];
                var balance = decimal.Parse(dataInput[2]);

                //add the data at dictionary and sum the balance if its needet
                if (!userBankInformation.ContainsKey(bankName))
                {
                    userBankInformation[bankName] = new Dictionary<string, decimal>();
                }
                if (!userBankInformation[bankName].ContainsKey(userAccount))
                {
                    userBankInformation[bankName][userAccount] = 0;
                }
                    userBankInformation[bankName][userAccount] += balance;

                userInput = Console.ReadLine();
            }

            return userBankInformation;
        }
        #endregion
    }
}
