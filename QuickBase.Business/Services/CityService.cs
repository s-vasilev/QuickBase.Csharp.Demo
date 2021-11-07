using AutoMapper;
using QuickBase.Business.Dtos;
using QuickBase.Business.Interfaces.Services;
using QuickBase.Business.Interfaces.SqliteData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Services
{
    /// <summary>The city service implementation.</summary>
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _uow;

        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="CityService" /> class.</summary>
        /// <param name="uow">The uow.</param>
        /// <param name="mapper">The mapper.</param>
        public CityService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>Gets the cities.</summary>
        /// <returns>The cities.</returns>
        public async Task<IEnumerable<CityDto>> GetCities()
        {
            var cities = await _uow.Cities.GetAll();
            var citiesDtos = _mapper.Map<IEnumerable<CityDto>>(cities);
            return citiesDtos;
        }
    }
}
