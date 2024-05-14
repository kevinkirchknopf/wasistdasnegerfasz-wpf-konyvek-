using irokkönyvek_20240409.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal class CountryService : ICountryService
    {
        private readonly Context _c;

        public CountryService(Context c)
        {
            _c = c;
        }
        bool ICountryService.AddCountry(Country ctry)
        {
            _c.Countries.Add(ctry);
            return true;
        }

        List<Country> ICountryService.GetAllCountry()
        {
           return (from c in _c.Countries select c).ToList<Country>();
        }

        Country ICountryService.GetCountryById(int id)
        {
            return (Country)from c in _c.Countries where c.Id==id select c;
        }
    }
}
