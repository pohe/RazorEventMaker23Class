using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Pages.Countries
{
    public class CountryEventsModel : PageModel
    {
        private ICountryRepository _countryRepository;
        private IEventRepository _eventRepository;
        public Country Country { get; set; }
        public List<Event> Events { get; set; }

        public CountryEventsModel(IEventRepository eventRepo, ICountryRepository countryRepo)
        {
            _countryRepository = countryRepo;
            _eventRepository = eventRepo;

        }
        public void OnGet(string code)
        {
            Events = _eventRepository.SearchEventByCode(code);
            Country = _countryRepository.GetCountry(code);
        }
    }
}
