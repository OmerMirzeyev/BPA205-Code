using Banking_Task.Models;

namespace Banking_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Account account1 = new Account();
            Account account2 = new Account();
            account1.OwnerName = "Omer Mirzeyev";
            account1.Balance = 500;
            account2.OwnerName = "Kenan Murselizade";
            account2.Balance = 10;
            account1.Deposit(100);
            account1.Withdraw(20);
            account2.Deposit(5);
            account2.Withdraw(2);
            account1.ShowAccountInfo();
            account2.ShowAccountInfo();
            bank.ShowBankInfo();
        }
    }
}
