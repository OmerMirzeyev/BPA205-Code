using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_Polymorphism__Virtual__Override.MOduls
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public virtual void Pay()
        {
            Console.WriteLine("Pay complated succesfully");
        }
        public virtual void Refund()
        {
            Console.WriteLine("Payment refund");
        }
    }
}
