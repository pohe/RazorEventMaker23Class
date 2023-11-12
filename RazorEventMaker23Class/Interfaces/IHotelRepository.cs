using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Interfaces
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotel(int id);

        void AddHotel(Hotel ho);
        void UpdateHotel();

    }
}
