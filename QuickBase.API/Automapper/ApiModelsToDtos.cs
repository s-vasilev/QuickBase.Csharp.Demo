using AutoMapper;
using QuickBase.API.ApiModels.Request;
using QuickBase.Business.Dtos;

namespace QuickBase.API.Automapper
{
    /// <summary>Automapper profile for Api models to Dtos mappings.</summary>
    public class ApiModelsToDtos : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="ApiModelsToDtos" /> class.</summary>
        public ApiModelsToDtos()
        {
            CreateMap<CountryRequest, CountryDto>();
        }
    }
}
