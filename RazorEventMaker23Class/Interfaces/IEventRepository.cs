using Microsoft.Extensions.Logging;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void DeleteEvent(Event ev);
        void UpdateEvent(Event ev);
        List<Event> FilterEvents(string filterCriteria);
    }
}
