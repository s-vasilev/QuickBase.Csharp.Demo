using AutoMapper;
using QuickBase.Business.Dtos;
using QuickBase.Domain.Models;

namespace QuickBase.Business.AutoMapper
{
    /// <summary>Automapper profile for Dtos to Entities models mappings.</summary>
    public class DtoToEntityProfile : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="DtoToEntityProfile" /> class.</summary>
        public DtoToEntityProfile()
        {
            CreateMap<CityDto, City>()
                .ForMember(c => c.CityId, opt => opt.MapFrom(c => c.Id))
                .ForMember(c => c.CityName, opt => opt.MapFrom(c => c.Name));

            CreateMap<StateDto, State>()
                .ForMember(s => s.StateId, opt => opt.MapFrom(s => s.Id))
                .ForMember(s => s.StateName, opt => opt.MapFrom(s => s.Name));

            CreateMap<CountryDto, Country>()
                .ForMember(co => co.CountryId, opt => opt.MapFrom(co => co.Id))
                .ForMember(co => co.CountryName, opt => opt.MapFrom(co => co.Name))
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
