using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIHoGent.Model
{
    public interface ICountryRepository
    {
        void AddCountry(Country country);
        Country GetCountry(int id);
        IEnumerable<Country> GetAll(string continent);
        void RemoveCountry(Country country);
        void UpdateCountry(Country country);
        void GetAll();
    }
}
