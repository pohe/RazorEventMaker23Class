using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Interfaces
{
    public interface IHotelBookingRepository
    {
        List<HotelBooking> GetAllHotelBookings();
        void AddHotelBooking(HotelBooking hotelbooking);
        HotelBooking GetHotelBookingById(int id);
        List<HotelBooking> GetHotelBookingByUserId(int userId);

        void DeleteHotelBooking(HotelBooking hotelBooking);

    }

}
