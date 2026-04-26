using Praktika.Extensions;

namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, longesssstttt world! This is a test.";
            Console.WriteLine($"Text {text}");
            Console.WriteLine($"The longest world {text.LongestWord()}");
            Console.WriteLine("---------------------------------------------------------------");
            int number = 121;
            Console.WriteLine($"'{number}' Is polindrom? {number.IsPolindrom()}");
            Console.WriteLine("----------------------------------------------");
            int number2 = 153;
            int number3 = 3;
            Console.WriteLine($"{number2} Is armstrong? {number2.IsArmstrong()}");
            Console.WriteLine($"{number3} Is prime? {number3.IsPrime()}");
            Console.WriteLine($"{number2} Number of sum: {number2.SumOfDigits()}");
            Console.WriteLine($"{number2} Reverse: {number2.ReverseNumber()}");
            Console.WriteLine("----------------------------------------------------");
            int[] arr = { 12, 45, 2, 51, 67, 8, 67, 10 };

            Console.Write("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine($"\n2nd largest element: {arr.SecondLargest()}");
        }
    }
}
