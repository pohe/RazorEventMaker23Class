using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;
using RazorEventMaker23Class.Services;
using System.ComponentModel;

namespace RazorEventMaker23Class.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event NewEvent { get; set; }

        public CreateEventModel(IEventRepository eventRepository)
        {
            //_repo = new EventRepository();
            _repo= eventRepository;
        }
        public void OnGet()  //Bruges til at hente/vise noget
        {
        }

        public IActionResult OnPost() //Bruges til at oprette/update/delete
        {
            _repo.AddEvent(NewEvent);
            return RedirectToPage("Index");
        }
    }
}
