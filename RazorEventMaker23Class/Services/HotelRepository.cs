using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Services
{
    public class HotelRepository : IHotelRepository
    {
        private Dictionary<int, Hotel> _hotels;

        public HotelRepository()
        {
            _hotels = new Dictionary<int, Hotel>();
            PopulateHotelsWithTestData();
        }

        public void AddHotel(Hotel hotel)
        {
            if (!_hotels.ContainsKey(hotel.Id))
            {
                _hotels.Add(hotel.Id, hotel);
            }
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotels.Values.ToList();
        }

        public Hotel GetHotel(int id)
        {
            if (!_hotels.ContainsKey(id))
            {
                return _hotels[id];
            }
            else
                return null;
        }

        public void UpdateHotel()
        {
            throw new NotImplementedException();
        }

        private void PopulateHotelsWithTestData()
        {
            _hotels.Add(1, new Hotel(1, "Crown Palaze", "Kongens Nytorv 1", "Deluze superior hotel"));
            _hotels.Add(2, new Hotel(2, "Hotel Hilton", "Lufthavnen 1", "Travellers choice"));
            _hotels.Add(3, new Hotel(3, "Petersens Hotel", "Legoland parkvej 3", "Familie hotel"));

        }
    }
}
