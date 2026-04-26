using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Library_System.Models
{
    public struct BookCode
    {
        public string Section { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return $"{Section}-{Number}";
        }
    }
}
