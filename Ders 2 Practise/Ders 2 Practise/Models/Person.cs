using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_2_Practise.Models
{
    public class Person
    {
        private string _name;
        public string Name 
        { 
            get { return _name; }  
            set 
            {
                if (value.Length != 0)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            } 
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set 
            {
                if (value.Length != 0)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Surname cannot be empty.");
                }
            }
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            
        }
        
    }
}
