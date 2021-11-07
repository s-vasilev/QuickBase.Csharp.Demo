using QuickBase.Business.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.Services
{
    /// <summary>Interface for the city service class.</summary>
    public interface ICityService
    {
        /// <summary>Gets the cities.</summary>
        /// <returns>The cities.</returns>
        Task<IEnumerable<CityDto>> GetCities();
    }
}
