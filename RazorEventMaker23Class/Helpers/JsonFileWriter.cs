using RazorEventMaker23Class.Models;
using System.Text.Json;

namespace RazorEventMaker23Class.Helpers
{
    public class JsonFileWriter
    {

        public static void WriteToJson(List<Event> events, string jsonFileName)
        {
            using(FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true
                }
                );
                JsonSerializer.Serialize<Event[]>(writter, events.ToArray());
            }
        }


        public static void WritetoJsonCountry(List<Country> countries, string jsonFileName)
        {
            
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Country[]>(writter, countries.ToArray());
            }
        }

        public static void WriteToJsonHotelBooking(List<HotelBooking> hotelsBookings, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<HotelBooking[]>(writter, hotelsBookings.ToArray());
            }
        }
    }
}
