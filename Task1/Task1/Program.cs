using System;
using Task1.Moduls;

class Program
{
    public static void Main()
    {
        ////2.1
        //Book myBook = new Book();
        //myBook.Name = "Sefiller";
        //myBook.Price = 15.50;
        //myBook.Author = "Victor Hugo";
        //myBook.ShowInfo();

    //1.2. ref — Balance sistemi
    //double balance = 1000.0;
    //Console.WriteLine($"Cari balans: {balance}AZN");
    //Withdraw(ref balance, 200);
    //Console.WriteLine($"Sonraki balans {balance}AZN");

    //1.3. out — Ən böyük və ən kiçik tap Task:
    //int min;
    //int max;
    //int[] arr = [1,2,3,4,5];
    //GetMinMax(arr, out min, out max);
    //foreach (int item in arr)
    //{
    //    Console.WriteLine($"Massivin ededleri; {item}");
    //}
    //Console.WriteLine($"En kiçik element: {min}");
    //Console.WriteLine($"En böyük element: {max}");

    //1.4. ref + out birlikdə Task:
    //bool isEven;
    //int number = int.Parse(Console.ReadLine());
    //Console.WriteLine($"Eded {number}");
    //bool succes = ProcessNumber(ref number, out isEven);
    //if ( succes)
    //{
    //    Console.WriteLine($"İki qat artırılmış eded: {number}");
    //    Console.WriteLine($"Bu eded cutdurmu? {isEven}");
    //}


    //1.1 ref — Array daxilində elementləri dəyiş
    //    int[] numbers = { 10, 20, 30, 40, 50 };
    //    int incrementValue = 5;

    //    Console.WriteLine("Metoddan once: ");
    //    foreach (var item in numbers)
    //    {
    //        Console.Write(item + " "); // Elementləri yan-yana boşluqla çap edir
    //    }

    //    IncreaseAll(ref numbers, incrementValue);

    //    Console.WriteLine($"\n Metondan sonra {incrementValue} qeder artir:");
    //    foreach (var item in numbers)
    //    {
    //        Console.Write(item + " ");
    //    }
    //}
    //public static void IncreaseAll(ref int[] arr, int value)
    //{
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] += value;
    //    }
    //}

}

    //public static void Withdraw(ref double balance, double amount)
    //{
    //    amount = double.Parse(Console.ReadLine());
    //    if (balance >= amount)
    //    {
    //        balance -= amount;
    //        Console.WriteLine($"{amount} AZN ugurla cixarildi.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Kifayet qeder balans yoxdur");
    //    }
    //}

    //public static void GetMinMax(int[] arr, out int min, out int max)
    //{
    //    min = arr[0];
    //    max = arr[0];
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] < min)
    //        {
    //            min = arr[i];
    //        }
    //        if (arr[i] > max)
    //        {
    //            max = arr[i];
    //        }
    //    }
    //}
    //public static bool ProcessNumber(ref int number, out bool isEven)
    //{
    //    number *= 2;
    //    if(number % 2 == 0)
    //    {
    //        isEven = true;
    //    }
    //    else
    //    {
    //        isEven = false;
    //    }

    //    return true;
    //}
}