namespace RazorEventMaker23Class.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Hotel()
        {
        }

        public Hotel(int id, string name, string address, string description)
        {
            Id = id;
            Name = name;
            Address = address;
            Description = description;
        }
    }

}
