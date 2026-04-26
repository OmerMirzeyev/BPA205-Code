using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_Polymorphism__Virtual__Override.MOduls
{
    public class CreditCardPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Credit card payment completed successfully.");
        }
        public override void Refund()
        {
            Console.WriteLine("Credit card payment refunded.");
        }
    }
}
