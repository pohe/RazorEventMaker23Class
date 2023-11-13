using Microsoft.AspNetCore.Mvc;
using RazorEventMaker23Class.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;

namespace RazorEventMaker23Class.Pages.Events
{
    public class EditEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event EventToUpdate { get; set; }

        public EditEventModel(IEventRepository eventRepository)
        {

            _repo = eventRepository;

        }
        public void OnGet(int id)
        {
            EventToUpdate= _repo.GetEvent(id);
        }

        public IActionResult OnPostUpdate()
        {
            _repo.UpdateEvent(EventToUpdate);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            _repo.DeleteEvent(EventToUpdate);
            return RedirectToPage("Index");
        }

    }
}
