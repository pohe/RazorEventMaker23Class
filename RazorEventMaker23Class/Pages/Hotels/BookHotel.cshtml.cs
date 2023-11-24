using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Hotels
{
    public class BookHotelModel : PageModel
    {
        private IHotelRepository _hotelRepository;
        private IUserService _userService;
        private IHotelBookingRepository _hotelBookingRepository;


        public SelectList   HotelNames { get; set; }
        public SelectList UserNames { get; set; }

        private List<string> _facilities;
        public List<string> Facilities { get { return _facilities; } }

        [BindProperty]
        public List<string> AreChecked { get; set; }

        public List<string> PriceModel { get; }

        [BindProperty]
        public HotelBooking HotelBooking { get; set; }
        public BookHotelModel(IHotelRepository hotelRepo,  IUserService userservice, IHotelBookingRepository bookingRepository)
        {
            _hotelRepository = hotelRepo;
            _userService = userservice;
            _hotelBookingRepository = bookingRepository;
            List<Hotel> hotels=_hotelRepository.GetAllHotels();
            HotelNames = new SelectList(hotels, "Id", "Name");
            List<User> users= _userService.GetAllUsers();
            UserNames = new SelectList(users, "UserId", "Name");
            _facilities = new List<string>() { "Swimmingpool", "VIP area", "Restaurant", "Fittness room"};

            PriceModel = new List<string>() { "Discount", "Standard", "Luxus" };

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //HotelBooking.Facilities.AddRange(AreChecked);
            HotelBooking.Facilities=AreChecked;
            _hotelBookingRepository.AddHotelBooking(HotelBooking);
            return RedirectToPage("ListHotelBookings");
        }
       
    }
}
