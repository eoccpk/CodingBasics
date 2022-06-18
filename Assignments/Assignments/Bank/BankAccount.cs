using System;

namespace Assignments.Bank
{
    public class BankAccount
    {
        public string AccountTitle { get; set; } // Kamran Qadir
        public string AccountNumber { get; set; } // 0011223344
        public AccountType AccountType { get; set; } // Current, Saving, Fixed
        public double Balance { get; set; } // 101.01
        public string BranchCode { get; set; } // 0501
        public string BranchName { get; set; } // Main Branch

        public BankAccount()
        {
            AccountTitle = "Kamran Qadir";
            AccountNumber = "0011223344";
            AccountType = AccountType.Current;
            Balance = 101.01;
            BranchCode = "0501";
            BranchName = "Main Branch";
        }

        public void Deposit(double Amount)
        {
            Console.WriteLine("Deposit Function");
            // 1000 + 500
            Balance = Balance + Amount;
            Console.WriteLine("Current Balance: " + Balance);
        }

        public void WithDraw(double Amount)
        {
            Console.WriteLine("WithDraw Function");
            // 1000 - 500
            Balance = Balance - Amount;
            Console.WriteLine("Current Balance: " + Balance);
        }
    }

}
