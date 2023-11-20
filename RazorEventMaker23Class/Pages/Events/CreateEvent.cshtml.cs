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

        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public Event NewEvent { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public SelectList   CountryCodes { get; set; }
        public CreateEventModel(IEventRepository eventRepository, ICountryRepository cRepo, IWebHostEnvironment webHost)
        {
            this.webHostEnvironment = webHost;
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
            //if(!ModelState.IsValid)
            //{
            //    return Page();
            //}

            if(Photo !=null)
            {
                if (NewEvent.EventImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/eventimages", NewEvent.EventImage);
                    System.IO.File.Delete(filePath);
                }

                NewEvent.EventImage = ProcessUploadedFile();
            }

            _repo.AddEvent(NewEvent);
            return RedirectToPage("Index");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/eventimages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
