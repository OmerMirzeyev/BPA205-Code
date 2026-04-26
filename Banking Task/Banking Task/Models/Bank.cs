using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Task.Models
{
    public class Bank
    {
        public const string BankName = "CodeBank";
        public static int TotalAccounts;
        public static readonly DateTime CreatedDate;
        static Bank()
        {
            CreatedDate = DateTime.Now;
        }

        public void ShowBankInfo()
        {
            Console.WriteLine($"BankName; {BankName}, TotalAccount; {TotalAccounts}, DateTime; {CreatedDate}");
        }
    }
}
