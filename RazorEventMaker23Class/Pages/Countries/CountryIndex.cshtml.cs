using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Countries
{
    public class CountryIndexModel : PageModel
    {
        private ICountryRepository countryRepository;

        public List<Country> Countries { get; set; }
        public CountryIndexModel(ICountryRepository crepo)
        {
            countryRepository = crepo;
        }
        public void OnGet()
        {
            Countries = countryRepository.GetAllCountries();
        }
    }
}
