using QuickBase.Business.Interfaces.SqliteData;
using QuickBase.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.Repositories
{
    /// <summary>Interface for the state repository class.</summary>
    public interface IStateRepository : IGenericRepo<State>
    {
        /// <summary>Gets the states.</summary>
        /// <returns>The states.</returns>
        Task<List<State>> GetStates();
    }
}
