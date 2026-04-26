using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace The_user_creates_events_and_manages_their_timing_.Structes
{
    public struct EventTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public EventTime(int year, int month, int day, int hour)
        {
            Year = year; 
            Month = month; 
            Day = day; 
            Hour = hour;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hour, 0, 0);
        }

    }
}
