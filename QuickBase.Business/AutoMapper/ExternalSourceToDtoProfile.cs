using AutoMapper;
using QuickBase.Business.Dtos;
using System;

namespace QuickBase.Business.AutoMapper
{
    /// <summary>Automapper profile for External Source to Dtos models mappings.</summary>
    public class ExternalSourceToDtoProfile : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="ExternalSourceToDtoProfile" /> class.</summary>
        public ExternalSourceToDtoProfile()
        {
            CreateMap<Tuple<string, int>, CountryDto>()
                    .ForMember(c => c.Name, opt => opt.MapFrom(s => s.Item1))
                    .ForMember(c => c.Population, opt => opt.MapFrom(s => s.Item2));
        }

    }
}
