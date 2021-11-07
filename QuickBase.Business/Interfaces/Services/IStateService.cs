using QuickBase.Business.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.Services
{
    /// <summary>Interface for the state service class.</summary>
    public interface IStateService
    {
        /// <summary>Gets the states.</summary>
        /// <returns>The states.</returns>
        Task<IEnumerable<StateDto>> GetStates();
    }
}
