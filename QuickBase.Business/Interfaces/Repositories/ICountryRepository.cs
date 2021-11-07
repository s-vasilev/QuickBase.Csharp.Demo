using QuickBase.Business.Interfaces.SqliteData;
using QuickBase.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.Repositories
{
    /// <summary>Interface for the country repository class.</summary>
    public interface ICountryRepository : IGenericRepo<Country>
    {
        /// <summary>Gets the countries.</summary>
        /// <returns>The countries.</returns>
        Task<IEnumerable<Country>> GetCountries();
    }
}
