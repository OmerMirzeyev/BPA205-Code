using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Task.Models
{
    public class Account
    {
        public readonly string accountNumber;
        public static int accountCounter;
        private string _ownerName;
        public string OwnerName
        {
            get { return _ownerName; }
            set
            {
                if (value.Length != 0)
                {
                    _ownerName=value;
                }
                else
                {
                    Console.WriteLine("Ad bos ola bilmez");

                }
            }
        }
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value > 0)
                {
                    _balance=value;
                }
                else
                {
                    Console.WriteLine("Balans menfi ola bilmez");
                }
            }
        }
        public Account()
        {
            accountNumber = $"ACC{accountCounter + 1:0000}";
            Bank.TotalAccounts++;
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Amount Balancdan cox ola bilmez");
            }
            else
            {
                Balance -= amount;
            }
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine($"AccountNumber; {OwnerName}, Balance; {Balance}, AccountNumber; {accountNumber}");
        }
    }

}
