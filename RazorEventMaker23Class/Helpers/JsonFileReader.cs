﻿using RazorEventMaker23Class.Models;
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

    }
}
