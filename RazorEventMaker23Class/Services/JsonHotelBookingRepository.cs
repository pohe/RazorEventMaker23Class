using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;
using System.Runtime.CompilerServices;

namespace RazorEventMaker23Class.Services
{
    public class JsonHotelBookingRepository : IHotelBookingRepository
    {
        private string filePath = @"Data\JsonHotelBooking.json";
        public void AddHotelBooking(HotelBooking hotelbooking)
        {
            throw new NotImplementedException();
        }

        public void DeleteHotelBooking(HotelBooking hotelBooking)
        {
            throw new NotImplementedException();
        }

        public List<HotelBooking> GetAllHotelBookings()
        {
            throw new NotImplementedException();
        }

        public HotelBooking GetHotelBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HotelBooking> GetHotelBookingByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
