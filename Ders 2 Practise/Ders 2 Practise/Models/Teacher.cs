using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_2_Practise.Models
{
    public class Teacher : Person
    {
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set 
            {
                if (value.Length != 0)
                {
                    _subject = value;
                }
                else
                {
                    Console.WriteLine("Subject cannot be empty.");
                }
            }
        }
        private int _experienceYear;
        public int ExperienceYear
        {
            get { return _experienceYear; }
            set 
            {
                if (value >= 0 )
                {
                    _experienceYear = value;
                }
                else
                {
                    Console.WriteLine("Experience year cannot be negative.");
                }
            }
        }
        private bool _isFullTime;
        public bool IsFullTime
        {
            get { return _isFullTime; }
            set { _isFullTime = value; }

        }


        public Teacher(string name, string surname) : base(name, surname)
        {
        }
        public Teacher (string name, string surname, string subject, int experienceYear, bool isFullTime) : this(name, surname)
        {
            Subject = subject;
            ExperienceYear = experienceYear;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Subject: {Subject}, Experience Year: {ExperienceYear}, Is Full Time: {IsFullTime}");
        }
        public void CheckFulltime()
        {
            if (IsFullTime)
            {
                Console.WriteLine("The teacher works is full time.");
            }
            else
            {
                Console.WriteLine("The teacher works is part time.");
            }
        }
        public void GetExperienceLevel()
        {
            if(ExperienceYear >= 0 && ExperienceYear <= 2)
            {
                Console.WriteLine("Junior Teacher");
            }
            else if (ExperienceYear >= 3 && ExperienceYear <= 5)
            {
                Console.WriteLine("Middle Teacher");
            }
            else if (ExperienceYear >= 6 && ExperienceYear <= 10)
            {
                Console.WriteLine("Senior Teacher");
            }
            else if (ExperienceYear > 10)
            {
                Console.WriteLine("Expert Teacher");
            }
        }
    }

}
