using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_Polymorphism__Virtual__Override.MOduls
{
    public class CashPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Cash payment completed successfully.");
        }
        public override void Refund()
        {
            Console.WriteLine("Cash payment refunded.");
        }
    }
}
