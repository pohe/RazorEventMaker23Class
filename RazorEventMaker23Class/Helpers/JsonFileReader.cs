using RazorEventMaker23Class.Models;
using System.Text.Json;

namespace RazorEventMaker23Class.Helpers
{
    public class JsonFileReader<T>
    {
        public static List<T> ReadJson(string jsonFileName) 
        {
            using(var jsonFileReader = File.OpenText(jsonFileName))
            {
                string inddata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<T>>(inddata);
            }
        }


        //public static List<Country> ReadJsonCountry(string jsonFileName)
        //{
        //    using (var jsonFileReader = File.OpenText(jsonFileName))
        //    {
        //        string indata = jsonFileReader.ReadToEnd();
        //        return JsonSerializer.Deserialize<List<Country>>(indata);
        //    }
        //}

        //public static List<User> ReadJsonUsers(string jsonFileName)
        //{
        //    using (var jsonFileReader = File.OpenText(jsonFileName))
        //    {
        //        string indata = jsonFileReader.ReadToEnd();
        //        return JsonSerializer.Deserialize<List<User>>(indata);
        //    }
        //}

        //public static List<HotelBooking> ReadJsonHotelBookings(string jsonFileName)
        //{
        //    using (var jsonFileReader = File.OpenText(jsonFileName))
        //    {
        //        string indata = jsonFileReader.ReadToEnd();
        //        return JsonSerializer.Deserialize<List<HotelBooking>>(indata);
        //    }
        //}
    }
}
