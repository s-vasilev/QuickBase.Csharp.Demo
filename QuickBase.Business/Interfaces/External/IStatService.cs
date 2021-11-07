using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.External
{
    /// <summary>Interface for external source class.</summary>
    public interface IStatService
    {
        /// <summary>Gets the country populations.</summary>
        /// <returns>The list of country populations.</returns>
        List<Tuple<string, int>> GetCountryPopulations();

        /// <summary>Gets the country populations asynchronous.</summary>
        /// <returns>The list of country populations.</returns>
        Task<List<Tuple<string, int>>> GetCountryPopulationsAsync();
    }
}
