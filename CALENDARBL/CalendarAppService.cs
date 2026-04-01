using CALENDARDL;
using CALENDARMODELS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALENDARBL
{
    public class CalendarAppService
    {
        CalendarDB db = new CalendarDB();

        public void AddEvent(string name, string date)
        {
            if (name == " " || date == " ")
            {
                Console.WriteLine("Event Unsuccessfully Added");
                return;
            }

            EventModels e = new EventModels();
            e.name = name;
            e.date = date;

            db.AddEvent(e);

            Console.WriteLine("Event Successfully Added");
        }

        public void ShowEvents()
        {
            Console.WriteLine("================================");
            Console.WriteLine("SHOW EVENTS");
            db.ShowEvents();
        }
    }

}


