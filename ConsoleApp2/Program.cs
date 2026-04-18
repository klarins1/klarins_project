using CALENDARBL;

namespace Tilaon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalendarAppService BL = new CalendarAppService();

            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("============CALENDAR============");
                Console.WriteLine("================================");
                Console.WriteLine("1 - ADD EVENT ");
                Console.WriteLine("2 - SHOW HOLIDAYS");
                Console.WriteLine("3 - SHOW EVENTS");
                Console.WriteLine("4 - EXIT");
                Console.WriteLine("================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("================================");
                        Console.WriteLine("ADD EVENT");

                        Console.Write("Name Of Event: ");
                        string eventName = Console.ReadLine();

                        Console.Write("Date of Event (MM/dd/yyyy): ");
                        string dateInput = Console.ReadLine();

                        BL.AddEvent(eventName, dateInput);
                        break;

                    case "2":
                        Console.WriteLine("================================");
                        Console.WriteLine("PH REGULAR HOLIDAYS");
                        Console.WriteLine("New Year's Day ------- 01/01/26");
                        Console.WriteLine("Maundy Thursday ------ 04/02/26");
                        Console.WriteLine("Good Friday ---------- 04/03/26");
                        Console.WriteLine("Araw ng Kagitingan --- 04/09/26");
                        Console.WriteLine("Labor Day ------------ 05/01/26");
                        Console.WriteLine("Independence Day ----- 06/12/26");
                        Console.WriteLine("National Heroes Day -- 08/25/26");
                        Console.WriteLine("Bonifacio Day -------- 11/30/26");
                        Console.WriteLine("Christmas Day -------- 12/25/26");
                        Console.WriteLine("Rizal Day ------------ 12/30/26");
                        break;

                    case "3":
                        BL.ShowEvents();
                        break;

                    case "4":
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}