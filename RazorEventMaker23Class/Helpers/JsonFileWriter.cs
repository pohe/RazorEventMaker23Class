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
    }
}
