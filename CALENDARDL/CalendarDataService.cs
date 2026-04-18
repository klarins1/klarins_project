using System;
using System.Collections.Generic;
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
            events = jsonProvider.LoadFromFile();

            if (events.Count == 0)
            {
                Console.WriteLine("No events found.");
                return;
            }

            Console.WriteLine("================================");

            foreach (var ev in events)
            {
                Console.WriteLine($"Event: {ev.name}");
                Console.WriteLine($"Date : {ev.date}");
                Console.WriteLine("================================");
            }
        }
    }
}



