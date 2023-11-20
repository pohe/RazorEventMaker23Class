using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Services
{
    public class JsonCountryRepository : ICountryRepository
    {
        string filePath = @"Data\JsonCountries.json";

        public void AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCountry(string code)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(string code)
        {
            throw new NotImplementedException();
        }
    }
}
