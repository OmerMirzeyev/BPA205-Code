using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class User
    {
        private string _name;
        private string _email;
        public string Name { get; set; }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length != 0)
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Email cannot empty.");
                }
            }
        }
            public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
