using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Hotels
{
    public class CreateHotelModel : PageModel
    {
        private IHotelRepository _repoHotel;

        [BindProperty]
        public Hotel NewHotel { get; set; }

        public CreateHotelModel(IHotelRepository hotelRepository)
        {
            _repoHotel = hotelRepository;
        }
        public void OnGet()  //Bruges til at hente/vise noget
        {
        }

        public IActionResult OnPost() //Bruges til at oprette/update/delete
        {
            _repoHotel.AddHotel(NewHotel);
            return RedirectToPage("Index");
        }
    }
}
