using System.ComponentModel.DataAnnotations;

namespace RazorEventMaker23Class.Models
{
    public class Country
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
