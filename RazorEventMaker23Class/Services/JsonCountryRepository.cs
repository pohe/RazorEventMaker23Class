using RazorEventMaker23Class.Helpers;
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
            return JsonFileReader.ReadJsonCountry(filePath);
        }

        public Country GetCountry(string code)
        {
            foreach (Country country in GetAllCountries())
            {
                if (country.Code == code)
                    return country;
            }
            return null;//new Country()
        }
    }
}
