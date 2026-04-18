using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CALENDARMODELS;

namespace CALENDARDL
{
    public class CalendarJson
    {
        private string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "calendar_data.json"
        );

        public void SaveToFile(List<EventModels> events)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(events,
                    new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }
        }

        public List<EventModels> LoadFromFile()
        {
            try
            {
                if (!File.Exists(filePath))
                    return new List<EventModels>();

                string jsonString = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<List<EventModels>>(jsonString)
                       ?? new List<EventModels>();
            }
            catch
            {
                return new List<EventModels>();
            }
        }
    }
}

