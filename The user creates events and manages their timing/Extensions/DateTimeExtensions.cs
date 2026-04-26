using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_user_creates_events_and_manages_their_timing_.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime date)
        {
            if(DayOfWeek.Saturday == date.DayOfWeek || DayOfWeek.Sunday == date.DayOfWeek)
            {
                return true;
            }
            return false;
        }
    }
}
