namespace _02.Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }

    public class OptimizedBankingSystem
    {
        public static void Main()
        {

            List<BankAccount> bankAccounts = new List<BankAccount>();

            string[] userInputLine = Console.ReadLine()
                .Split(" |".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);


            while (userInputLine[0] != "end")
            {
                string bank = userInputLine[0];
                string name = userInputLine[1];
                decimal balance = decimal.Parse(userInputLine[2]);


                BankAccount newBankAccount = new BankAccount()
                {
                    Name = name,
                    Bank = bank,
                    Balance = balance
                };


                bankAccounts.Add(newBankAccount);

                userInputLine = Console.ReadLine()
                .Split(" |".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            }
            bankAccounts = bankAccounts
                .OrderBy(n => n.Bank.Length)
                .OrderByDescending(bal => bal.Balance)
                .ToList();

            foreach (var account in bankAccounts)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }

        }
    }
}
