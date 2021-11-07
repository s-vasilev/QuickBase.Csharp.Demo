using QuickBase.Business.Interfaces.Repositories;
using QuickBase.Business.Interfaces.SqliteData;
using System.Threading.Tasks;

namespace QuickBase.SqliteData
{
    /// <summary>The unit of work implemention.</summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqliteContext _context;

        /// <summary>Initializes a new instance of the <see cref="UnitOfWork" /> class.</summary>
        /// <param name="context">The context.</param>
        /// <param name="cities">The cities.</param>
        /// <param name="countries">The countries.</param>
        /// <param name="states">The states.</param>
        public UnitOfWork(SqliteContext context, ICityRepository cities, ICountryRepository countries, IStateRepository states)
        {
            _context = context;
            Cities = cities;
            Countries = countries;
            States = states;
        }

        /// <summary>Gets the cities.</summary>
        /// <value>The cities.</value>
        public ICityRepository Cities { get; }

        /// <summary>Gets the countries.</summary>
        /// <value>The countries.</value>
        public ICountryRepository Countries { get; }

        /// <summary>Gets the states.</summary>
        /// <value>The states.</value>
        public IStateRepository States { get; }

        /// <summary>Saves this changes to the database.</summary>
        /// <returns>The result of the operation.</returns>
        public async Task<bool> Save()
        {
            var changeAmount = await _context.SaveChangesAsync();
            return changeAmount > 0;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
