using Bir_məktəb_sistemi_modeli_qurun_.Models;

namespace Bir_məktəb_sistemi_modeli_qurun_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Omer", "Mirzeyev", 20);
            Student student2 = new Student("Kenan", "Murselizade", 22);
            Student student3 = new Student("Rovsen", "Mammadov", 19);
            student1.GetInfo();
            student2.GetInfo();
            student3.GetInfo();
            Console.WriteLine("--------------------------------------");
            student1.GetStudentCount();
        }
    }
}
