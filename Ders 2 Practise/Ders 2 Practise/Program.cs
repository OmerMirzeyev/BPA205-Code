using Ders_2_Practise.Models;

namespace Ders_2_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Omar", "Mirzayev");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.WriteLine("--------------------------------------");
            Teacher teacher = new Teacher("Laman", "Bayramova");
            teacher.Subject = "Math";
            teacher.ExperienceYear = 10;
            teacher.IsFullTime = true;
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher.Subject);
            Console.WriteLine(teacher.ExperienceYear);
            Console.WriteLine("---------------------------------------");
            teacher.GetInfo();
            teacher.CheckFulltime();
            teacher.GetExperienceLevel();
        }
    }
}
