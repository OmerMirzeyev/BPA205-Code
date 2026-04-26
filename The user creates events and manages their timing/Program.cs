using System.Security.Cryptography.X509Certificates;
using The_user_creates_events_and_manages_their_timing_.Extensions;
using The_user_creates_events_and_manages_their_timing_.Records;
using The_user_creates_events_and_manages_their_timing_.Structes;

namespace The_user_creates_events_and_manages_their_timing_
{
    public class Program
    {
        static void Main(string[] args)
        {

            EventTime eventTime = new EventTime(2028,11,1,13);

            EventTime eventTime1 = new EventTime(2024, 06, 2, 21);

            EventTime eventTime2 = new EventTime(2026, 4, 10, 15);

            Event day1 = new Event("gun1", eventTime, DateTime.Now);
            Event day2 = new Event("gun2", eventTime1, DateTime.Now);
            Event day3 = new Event("gun3", eventTime2, DateTime.Now);

            if (eventTime.ToDateTime() > DateTime.Now)
            {
                Console.WriteLine($"{day1.Title}Tarix gelecekdedir");

                TimeSpan diff = eventTime.ToDateTime() - DateTime.Now;
                Console.WriteLine($"{diff.Days} gun qalib {eventTime.ToDateTime()}");
            }
            else
            {
                Console.WriteLine("Event bitdi");
            }

            if (eventTime1.ToDateTime() > DateTime.Now)
            {
                Console.WriteLine($"{day2.Title}Tarix gelecekdedir");
                TimeSpan diff = eventTime1.ToDateTime() - DateTime.Now;
                Console.WriteLine($"{diff.Days} gun qalib {eventTime1.ToDateTime()}");
            }
            else
            {
                Console.WriteLine("Event1 bitdi");
            }

            if (eventTime2.ToDateTime() > DateTime.Now)
            {
                Console.WriteLine($"{day3.Title}Tarix gelecekdedir");

                TimeSpan diff = eventTime2.ToDateTime() - DateTime.Now;
                Console.WriteLine($"{diff.Days} gun qalib {eventTime2.ToDateTime()}");
            }
            else
            {
                Console.WriteLine("Event2 bitdi");
            }
            Console.WriteLine("Hefte sonudurmu");
            Console.WriteLine($"{day1.Title}, {eventTime.ToDateTime().IsWeekend()}");
            Console.WriteLine($"{day2.Title}, {eventTime1.ToDateTime().IsWeekend()}");
            Console.WriteLine($"{day3.Title}, {eventTime2.ToDateTime().IsWeekend()}");

        }
    }
}
