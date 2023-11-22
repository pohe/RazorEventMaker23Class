using RazorEventMaker23Class.Models;
using System.Text.Json;

namespace RazorEventMaker23Class.Helpers
{
    public class JsonFileReader
    {
        public static List<Event> ReadJson(string jsonFileName) 
        {
            using(var jsonFileReader = File.OpenText(jsonFileName))
            {
                string inddata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(inddata);
            }
        }


        public static List<Country> ReadJsonCountry(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Country>>(indata);
            }
        }

        public static List<User> ReadJsonUsers(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<User>>(indata);
            }
        }
    }
}
