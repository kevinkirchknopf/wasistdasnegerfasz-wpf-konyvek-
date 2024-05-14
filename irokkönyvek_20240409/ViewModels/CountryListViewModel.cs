using irokkönyvek_20240409.Models;
using irokkönyvek_20240409.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.ViewModels
{
    class CountryListViewModel
    {
        private readonly ICountryService _service;

        public ObservableCollection<Country> countrylist { get; set; }

        public CountryListViewModel(ICountryService service)
        {
            _service = service;
            countrylist = new ObservableCollection<Country>(_service.GetAllCountry());
        }
    }
}
