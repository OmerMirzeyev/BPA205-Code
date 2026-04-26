using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_Polymorphism__Virtual__Override.MOduls
{
    public class CryptoPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Crypto payment completed successfully.");
        }
        public override void Refund()
        {
            Console.WriteLine("Crypto payment refunded.");
        }
    }
}
