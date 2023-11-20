using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorEventMaker23Class.Models
{
    public class Event
    {
        
        public int Id { get; set; }

        [DisplayName("Landekode")]
        public string CountryCode  { get; set; }

        [Display(Name="Event Name")]
        [Required(ErrorMessage = "Name of the event is required"), MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [StringLength(18, ErrorMessage="CIty of the event can not be longer than 18")]
        public string City { get; set; }

        [Required(ErrorMessage ="Date is required")]
        [Range(typeof(DateTime), "12/11/2023", "12/11/2024")]
        public DateTime DateTime { get; set; }

        public Event()
        {
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else if (!(obj is Event)) return false;
            else if ( ((Event)obj).Id == this.Id)
                return true;

            return false;
        }
    }
}
