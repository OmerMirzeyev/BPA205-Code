using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Library_System.Models
{
    public static class DateTimeExtension
    {
        public static bool IsNew(this DateTime date)
        {
            if(DateTime.Now - date <= TimeSpan.FromDays(7))
            {
                return true;
            }
            return false;
        }
    }
}
