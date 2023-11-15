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

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(FilterCriteria)) 
            {
                Events = _repo.FilterEvents(FilterCriteria);
            }
            else
            {
                Events = _repo.GetAllEvents();
            }
            
        }
    }
}
