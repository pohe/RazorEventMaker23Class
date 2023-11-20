using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public SelectList   CountryCodes { get; set; }
        public CreateEventModel(IEventRepository eventRepository, ICountryRepository cRepo)
        {
            List<Country> countries = cRepo.GetAllCountries();
            CountryCodes = new SelectList(countries, "Code", "Name");
            //_repo = new EventRepository();
            _repo= eventRepository;
        }
        public void OnGet()  //Bruges til at hente/vise noget
        {
        }

        public IActionResult OnPost() //Bruges til at oprette/update/delete
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _repo.AddEvent(NewEvent);
            return RedirectToPage("Index");
        }
    }
}
