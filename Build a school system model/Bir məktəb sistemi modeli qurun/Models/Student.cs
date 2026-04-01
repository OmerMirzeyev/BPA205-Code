using System;
using System.Collections.Generic;
using System.Text;

namespace Bir_məktəb_sistemi_modeli_qurun_.Models
{
    public class Student
    {
        public static int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public const string SchoolName = "Code Academy";
        public static int studentCount;
        public readonly string studentCode;
        public int StudentId;
        public Student(string name, string surname, int age)
        {
            Id++;
            Name = name;
            Surname = surname;
            Age = age;
            studentCount++;
            studentCode = $"STU{Id:0000}";
            StudentId = Id;
        }
        public void GetStudentCount()
        {
            Console.WriteLine($"Total number of students: {studentCount}");
        }  
            public void GetInfo()
            {
                Console.WriteLine($"Student Code: {studentCode},Id: {StudentId}, Name: {Name} {Surname}, Age: {Age}, School: {SchoolName}");
            }
    }
}
