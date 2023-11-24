using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Hotels
{
    public class ListHotelBookingsModel : PageModel
    {
        private IHotelBookingRepository hotelBookingRepository;

        public List<HotelBooking> Bookings { get; set; }
        public ListHotelBookingsModel(IHotelBookingRepository hotelbookingRepo)
        {
            hotelBookingRepository = hotelbookingRepo;
            Bookings = hotelBookingRepository.GetAllHotelBookings();
        }
        public void OnGet()
        {
        }
    }
}
