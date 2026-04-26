using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_user_creates_events_and_manages_their_timing_.Structes;

namespace The_user_creates_events_and_manages_their_timing_.Records
{
    public record Event
    {
        public string Title { get; set; }
        public EventTime Time { get; set; }
        public DateTime CreatedeAt { get; set; }
        
        public Event(string title, EventTime time, DateTime createdAt)
        {
            Title = title;
            Time = time;
            CreatedeAt = createdAt;
        }

    }
}
