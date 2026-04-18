using CALENDARDL;
using CALENDARMODELS;
using System;
using System.Globalization;

namespace CALENDARBL
{
    public class CalendarAppService
    {
        private CalendarDataService dataService = new CalendarDataService();

        public void AddEvent(string name, string date)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(date))
            {
                Console.WriteLine("Event Unsuccessfully Added (empty input)");
                return;
            }

            if (!DateTime.TryParseExact(date, "MM/dd/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedDate))
            {
                Console.WriteLine("Invalid date format. Use MM/dd/yyyy");
                return;
            }

            EventModels e = new EventModels
            {
                name = name,
                date = parsedDate.ToString("MM/dd/yyyy")
            };

            dataService.AddEvent(e);

            Console.WriteLine("Event Successfully Added");
        }

        public void ShowEvents()
        {
            Console.WriteLine("================================");
            Console.WriteLine("SHOW EVENTS");
            dataService.ShowEvents();
        }
    }
}