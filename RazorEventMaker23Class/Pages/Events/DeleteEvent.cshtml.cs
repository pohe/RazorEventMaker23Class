using Microsoft.AspNetCore.Mvc;
using RazorEventMaker23Class.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;

namespace RazorEventMaker23Class.Pages.Events
{
    public class DeleteEventModel : PageModel
    {
        private IEventRepository _repo;

        //[BindProperty]
        public Event DeleteEvent { get; set; }


        public DeleteEventModel(IEventRepository repo)
        {
            _repo = repo;
        }
        public IActionResult OnGet(int deleteId)
        {
            DeleteEvent =_repo.GetEvent(deleteId);
            return Page();
        }

        public IActionResult OnPostDelete(int nummer)
        {
            DeleteEvent = _repo.GetEvent(nummer);
            _repo.DeleteEvent(DeleteEvent);
            return RedirectToPage("Index");
        }
    }
}
