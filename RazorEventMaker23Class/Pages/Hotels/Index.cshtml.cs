using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Hotels
{
    public class IndexModel : PageModel
    {
        private IHotelRepository _repoHotels;

        public List<Hotel> Hotels { get; private set; }


        public IndexModel(IHotelRepository hotelRepository)
        {
            _repoHotels = hotelRepository;
        }
        public void OnGet()
        {
            Hotels = _repoHotels.GetAllHotels();
        }
    }
}
