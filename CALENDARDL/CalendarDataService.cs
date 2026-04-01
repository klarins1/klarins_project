using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALENDARMODELS;

namespace CALENDARDL
{
    public class CalendarDataService
    {
        private List<EventModels> events;
        private CalendarJson jsonProvider = new CalendarJson();

        public CalendarDataService()
        {
            events = jsonProvider.LoadFromFile();
        }

        public void AddEvent(EventModels e)
        {
            events.Add(e);
            jsonProvider.SaveToFile(events);
        }

        public void ShowEvents()
        {
            if (events.Count == 0)
            {
                Console.WriteLine("NO EVENTS SHOW");
                return;
            }
            foreach (var eventss in events)
            {
                {
                    Console.WriteLine($"Event: {eventss.name}");
                    Console.WriteLine($"Date: {eventss.date}");
                    Console.WriteLine("================================");
                }
            }
        }
    }
}


