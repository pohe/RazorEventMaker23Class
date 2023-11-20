using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
        Country GetCountry(string code);
        void DeleteCountry(string code);
        void AddCountry(Country country);
    }
}
