using TASK_Polymorphism__Virtual__Override.MOduls;

namespace TASK_Polymorphism__Virtual__Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment();
            payment.Amount = 100;
            payment.Pay();
            Console.WriteLine("-------------------");
            Payment payment1 = new CashPayment();
            payment1.Amount = 100;
            payment1.Pay();
            Console.WriteLine("-------------------");
            Payment payment2 = new CreditCardPayment();
            payment2.Amount = 100;
            payment2.Pay();
            Console.WriteLine("-------------------");

            Payment payment3 = new CryptoPayment();
            payment3.Amount = 100;
            payment3.Pay();

        }
    }
}
