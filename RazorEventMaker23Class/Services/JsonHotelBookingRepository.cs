using RazorEventMaker23Class.Helpers;
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
            List<HotelBooking> bookings = GetAllHotelBookings();
            List<int> bookingsIds = new List<int>();

            foreach (var b in bookings)
            {
                bookingsIds.Add(b.BookingId);
            }
            if (bookingsIds.Count != 0)
            {
                int start = bookingsIds.Max();
                hotelbooking.BookingId = start + 1;
            }
            else
            {
                hotelbooking.BookingId = 1;
            }
            bookings.Add(hotelbooking);
            JsonFileWriter<HotelBooking>.WriteToJson(bookings, filePath);
        }

        public void DeleteHotelBooking(HotelBooking hotelBooking)
        {
            throw new NotImplementedException();
        }

        public List<HotelBooking> GetAllHotelBookings()
        {
            return JsonFileReader<HotelBooking>.ReadJson(filePath);
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
