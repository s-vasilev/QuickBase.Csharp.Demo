using AutoMapper;
using QuickBase.Business.Dtos;
using QuickBase.Domain.Models;

namespace QuickBase.Business.AutoMapper
{
    /// <summary>Automapper profile for Entities to Dtos models mappings.</summary>
    public class EntityToDtoProfile : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="EntityToDtoProfile" /> class.</summary>
        public EntityToDtoProfile()
        {
            CreateMap<City, CityDto>()
                .ForMember(c => c.Id, opt => opt.MapFrom(c => c.CityId))
                .ForMember(c => c.Name, opt => opt.MapFrom(c => c.CityName));

            CreateMap<State, StateDto>()
                .ForMember(s => s.Id, opt => opt.MapFrom(s => s.StateId))
                .ForMember(s => s.Name, opt => opt.MapFrom(s => s.StateName));

            CreateMap<Country, CountryDto>()
                .ForMember(co => co.Id, opt => opt.MapFrom(co => co.CountryId))
                .ForMember(co => co.Name, opt => opt.MapFrom(co => co.CountryName));
        }
    }
}
