using QuickBase.Business.Interfaces.Repositories;
using QuickBase.Domain.Models;

namespace QuickBase.SqliteData.Repositories
{
    /// <summary>The city repository implemention.</summary>
    public class CityRepository : GenericRepo<City>, ICityRepository
    {
        /// <summary>Initializes a new instance of the <see cref="CityRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public CityRepository(SqliteContext context)
            : base(context)
        {
        }
    }
}
