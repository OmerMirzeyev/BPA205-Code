using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class Customer : User
    {
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }
            public Customer(string name, string email, double balance) : base(name, email)
        {
            Balance = balance;
        }

    }
}
