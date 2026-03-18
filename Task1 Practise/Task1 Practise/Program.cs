namespace Task1_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            ////2.1 Verilən iki ədədin yerini dəyişdirən metod yazın.(üçüncü dəyişən yaradılmamalıdır)
            //Console.WriteLine("1-ci ededi daxil edin: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("2-ci ededi daxil edin: ");
            //int b = int.Parse(Console.ReadLine());
            //Swap(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");



            ////2.2 Verilmiş radius üçün dairənin sahəsini və uzunlugu out parametr vasitəsilə qaytaran metod yazın.
            //double field;
            //double length;
            //FieldAndLength(out field, out length, out int r);
            //Console.WriteLine($"Field: {field}");
            //Console.WriteLine($"Length: {length}");



            ////2.3 Metod bir int qəbul edir və ref ilə onun dəyərini 10% artırır.
            //Console.WriteLine("Enter integer: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Before the method integer: {num}");
            //Console.WriteLine("---------------------------------");
            //Percent(ref num);
            //Console.WriteLine($"After the method integer: {num}");



            //2.4 Verilmiş ədəd üçün out parametr vasitəsilə rəqəmlərin tərsini qaytarın.(Məsələn, 123 → 321.)
            //Polindrome(out int num);
            //Console.WriteLine($"After the method int: {num}");



            //2.5 Bir metod yazın ki, birinci string-i ref ilə qəbul etsin və params string[] istifadə edərək istədiyiniz qədər əlavə string-i birləşdirib nəticəni ilk string-də saxlasın(string.Concat kimi işləsin)
            //string a = "Ilk yazi";
            //string[] b = ["salam", "necesen", "neynirsen"];
            //String(ref a, b);
        }
        //public static void Swap(ref int a, ref int b)
        //{
        //    a += b;
        //    b = a - b;
        //    a -= b;
        //}



        //public static void FieldAndLength(out double field, out double length, out int r)
        //{
        //    Console.WriteLine("Radiusu daxil edin: ");
        //    r = int.Parse(Console.ReadLine());
        //    length = 2 * Math.PI * r;
        //    field = Math.PI * Math.Pow(r, 2);
        //}


        //public static void Percent(ref int num)
        //{
        //    num = num + ((num * 10) / 100);
        //}


        //public static void Polindrome(out int num)
        //{
        //    Console.WriteLine("Enter Value: ");
        //    num = int.Parse(Console.ReadLine());
        //    int temp = num;
        //    int reverse = 0;
        //    while (temp > 0)
        //    {
        //        int last = temp % 10;
        //        reverse = reverse * 10 + last;
        //        temp = temp / 10;

        //    }
        //    if (num == reverse)
        //    {
        //        Console.WriteLine("polindrom ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("polindrom eded deyil");
        //    }
        //}


        //public static void String(ref string a, params string[] b)
        //{
        //    foreach (var item in b)
        //    {
        //        a = item + a;

        //    }
        //    Console.WriteLine(a);
        //}
    }
}
}
