using Microsoft.EntityFrameworkCore;
using QuickBase.Business.Interfaces.Repositories;
using QuickBase.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBase.SqliteData.Repositories
{
    /// <summary>The country repository implemention.</summary>
    public class CountryRepository : GenericRepo<Country>, ICountryRepository
    {
        /// <summary>Initializes a new instance of the <see cref="CountryRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public CountryRepository(SqliteContext context)
            : base(context)
        {
        }

        /// <summary>Gets the countries.</summary>
        /// <returns>The countries.</returns>
        public async Task<IEnumerable<Country>> GetCountries()
        {
            var countries = await _context.Country.Include(x => x.States).ThenInclude(x => x.Cities).ToListAsync();
            return countries;
        }
    }
}
