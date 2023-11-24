using RazorEventMaker23Class.Helpers;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Services
{
    
    public class JsonEventRepository : IEventRepository
    {
        private string jsonFileName = @"Data\JsonEvents.json";

        public void AddEvent(Event ev)
        {
            List<int> eventIds = new List<int>();
            List<Event> events= GetAllEvents();
            foreach (var evt in events)
            {
                eventIds.Add(evt.Id);
            }
            if (eventIds.Count != 0)
            {
                int start = eventIds.Max();
                ev.Id = start + 1;
            }
            else
            {
                ev.Id = 1;
            }
            events.Add(ev);
            JsonFileWriter<Event>.WriteToJson(events, jsonFileName);
        }

        public void DeleteEvent(Event ev)
        {
            List<Event> events = GetAllEvents();
            events.Remove(ev);
            JsonFileWriter<Event>.WriteToJson(events, jsonFileName);
        }

        public List<Event> FilterEvents(string filterCriteria)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var evt in GetAllEvents() )
            {
                if (evt.Name.Contains(filterCriteria) || evt.City.Contains(filterCriteria) || evt.Description.Contains(filterCriteria))
                {
                    filteredList.Add(evt);
                }

            }

            return filteredList;
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader<Event>.ReadJson(jsonFileName);
        }

        public Event GetEvent(int id)
        {
            foreach (Event evt in GetAllEvents() )
            {
                if (evt.Id == id)
                    return evt;
            }
            return new Event();
        }

        public List<Event> SearchEventByCode(string code)
        {
            List<Event> countryEventList = new List<Event>();
            foreach (Event evt in GetAllEvents()) 
            { 
                if (evt.CountryCode == code)
                {
                    countryEventList.Add(evt);
                }
            }
            return countryEventList;
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                List<Event> events = GetAllEvents();
                foreach (Event e in events)
                {
                    if (ev.Id == e.Id)
                    {
                        e.Id = ev.Id;
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.City = ev.City;
                        e.DateTime = ev.DateTime;
                        break;
                    }
                }
                JsonFileWriter<Event>.WriteToJson(events, jsonFileName);
            }
        }
    }
}
