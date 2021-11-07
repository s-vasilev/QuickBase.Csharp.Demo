using QuickBase.Business.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.Services
{
    /// <summary>Interface for the country service class.</summary>
    public interface ICountryService
    {
        /// <summary>Gets the countries.</summary>
        /// <returns>The countries.</returns>
        Task<IEnumerable<CountryDto>> GetCountries();

        /// <summary>Gets the countries populations.</summary>
        /// <returns>The countries populations.</returns>
        Task<IEnumerable<CountryDto>> GetCountriesPopulations();

        /// <summary>Adds the country.</summary>
        /// <param name="country">The country.</param>
        Task AddCountry(CountryDto country);

        /// <summary>Updates the country.</summary>
        /// <param name="country">The country.</param>
        Task UpdateCountry(CountryDto country);
    }
}
