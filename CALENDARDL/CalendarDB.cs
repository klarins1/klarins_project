using CALENDARMODELS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CALENDARDL
{
    public class CalendarDB
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS; Database=CalendarEvents; Integrated Security=True; TrustServerCertificate=True;";

        public void AddEvent(EventModels e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EVENTS_DB (EVENT_NAME, EVENT_DATE) VALUES (@name, @date)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", e.name);
                cmd.Parameters.AddWithValue("@date", e.date);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ShowEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT EVENT_NAME, EVENT_DATE FROM EVENTS_DB";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Event: {reader["EVENT_NAME"]}");
                    Console.WriteLine($"Date: {reader["EVENT_DATE"]}");
                    Console.WriteLine("================================");
                }
                conn.Close();
            }
        }
    }
}
