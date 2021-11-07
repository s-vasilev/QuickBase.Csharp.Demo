using Microsoft.EntityFrameworkCore;
using QuickBase.Business.Interfaces.Repositories;
using QuickBase.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBase.SqliteData.Repositories
{
    /// <summary>The state repository implementation.</summary>
    public class StateRepository : GenericRepo<State>, IStateRepository
    {
        /// <summary>Initializes a new instance of the <see cref="StateRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public StateRepository(SqliteContext context)
            : base(context)
        {
        }

        /// <summary>Gets the states.</summary>
        /// <returns>The states.</returns>
        public async Task<List<State>> GetStates()
        {
            var states = await _context.State.Include(x => x.Cities).Where(x => x.StateId > 0).ToListAsync();
            return states;
        }
    }
}
