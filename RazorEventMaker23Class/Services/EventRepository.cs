using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Services
{
    public class EventRepository : IEventRepository
    {
        private List<Event> _events;

        public EventRepository() 
        {
            _events = new List<Event>();
            PopulateEventsWithTestData();
        
        
        }

        public void AddEvent(Event ev)
        {
            List<int> eventIds = new List<int>();

            foreach (var evt in _events)
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
            _events.Add(ev);
        }

        public void DeleteEvent(Event ev)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event ev)
        {
            throw new NotImplementedException();
        }


        private void PopulateEventsWithTestData()
        {
            _events.Add(new Event()
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = " A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2023, 6, 9, 10, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = " Many Marathon runners",
                City = "Copenhagen",
                DateTime = new DateTime(2023, 3, 6, 9, 30, 0)
            });
            _events.Add(new Event()
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = " A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2023, 6, 4, 14, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentation",
                City = "Roskilde",
                DateTime = new DateTime(2023, 6, 9, 9, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 5,
                Name = "VM Badminton",
                Description = "Badminton",
                City = "Århus",
                DateTime = new DateTime(2023, 10, 3, 16, 0, 0)
            });
        }

    }
}
