namespace RazorEventMaker23Class.Models
{

    public enum Vip
    {
        Vip =1,
        NotVip=2, 
        Unspecified=3
    }

    public enum Countries
    {
        America, 
        England, 
        Australia, 
        EU,
        Other
    }
    public class HotelBooking
    {

        public int BookingId { get; set; }
        public int HotelId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }

        public int NumberOfDays { get; set; }

        public List<string> Facilities { get; set; }

        public string PriceModel { get; set; }
        public Vip IsVip { get; set; }

        public Countries Country { get; set; }


    }
}
