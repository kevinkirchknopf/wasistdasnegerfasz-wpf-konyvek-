using irokkönyvek_20240409.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal interface ICountryService
    {
        public Country GetCountryById(int id);

        public List<Country> GetAllCountry();

        public bool AddCountry(Country c);
    }
}
