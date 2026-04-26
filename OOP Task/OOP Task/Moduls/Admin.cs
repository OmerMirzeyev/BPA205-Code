using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class Admin : User
    {
        private string _role;
        public string Role { get; set; }


        public Admin(string name, string email, string role) : base(name, email)
        {
            Role = role;
        }

    }
}
