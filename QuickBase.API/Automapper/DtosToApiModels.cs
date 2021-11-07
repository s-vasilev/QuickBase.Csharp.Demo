using AutoMapper;
using QuickBase.API.ApiModels.Response;
using QuickBase.Business.Dtos;

namespace QuickBase.API.Automapper
{
    /// <summary>Automapper profile for Dtos to Api models mappings.</summary>
    public class DtosToApiModels : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="DtosToApiModels" /> class.</summary>
        public DtosToApiModels()
        {
            CreateMap<CountryDto, CountryResponse>();
            CreateMap<StateDto, StateResponse>();
            CreateMap<CityDto, CityResponse>();
            CreateMap<CountryDto, CountryPopulationResponse>();
        }
    }
}
