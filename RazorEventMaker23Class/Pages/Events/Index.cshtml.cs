using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;


namespace RazorEventMaker23Class.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventRepository _repo;

        public List<Event> Events { get; private set; }

        public IndexModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }
        public void OnGet()
        {
            Events = _repo.GetAllEvents();
        }
    }
}
