using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Console_App
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
