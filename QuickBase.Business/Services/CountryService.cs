using AutoMapper;
using QuickBase.Business.Dtos;
using QuickBase.Business.Interfaces.External;
using QuickBase.Business.Interfaces.Helpers;
using QuickBase.Business.Interfaces.Services;
using QuickBase.Business.Interfaces.SqliteData;
using QuickBase.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBase.Business.Services
{
    /// <summary>The country service implementation.</summary>
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _uow;

        private readonly IMapper _mapper;

        private readonly IStatService _statService;

        private readonly ICountryNamesHelper _countryNamesHelper;

        /// <summary>Initializes a new instance of the <see cref="CountryService" /> class.</summary>
        /// <param name="uow">The uow.</param>
        /// <param name="mapper">The mapper.</param>
        /// <param name="statService">The stat service.</param>
        /// <param name="countryNamesHelper">The country names helper.</param>
        public CountryService(IUnitOfWork uow, IMapper mapper, IStatService statService, ICountryNamesHelper countryNamesHelper)
        {
            _uow = uow;
            _mapper = mapper;
            _statService = statService;
            _countryNamesHelper = countryNamesHelper;
        }

        /// <summary>Gets the countries.</summary>
        /// <returns>The countries.</returns>
        public async Task<IEnumerable<CountryDto>> GetCountries()
        {
            var countries = await _uow.Countries.GetCountries();
            var countryDtos = _mapper.Map<IEnumerable<CountryDto>>(countries);
            return countryDtos;
        }

        /// <summary>Adds the country.</summary>
        /// <param name="countryDto">The country dto.</param>
        public async Task AddCountry(CountryDto countryDto)
        {
            var country = _mapper.Map<Country>(countryDto);
            await _uow.Countries.Insert(country);
            await _uow.Save();
        }

        /// <summary>Updates the country.</summary>
        /// <param name="countryDto">The country dto.</param>
        public async Task UpdateCountry(CountryDto countryDto)
        {
            var country = _mapper.Map<Country>(countryDto);
            _uow.Countries.Update(country);
            await _uow.Save();
        }

        /// <summary>Gets the countries populations.</summary>
        /// <returns>The countries populations.</returns>
        public async Task<IEnumerable<CountryDto>> GetCountriesPopulations()
        {
            var countries = await _uow.Countries.GetCountries();
            var countryDtos = _mapper.Map<IEnumerable<CountryDto>>(countries).ToList();

            var countriesExternal = _statService.GetCountryPopulations();
            var countriesExternalDtos = _mapper.Map<IEnumerable<CountryDto>>(countriesExternal).ToList();

            var dbCountryNames = countryDtos.Select(x => x.Name).ToList();
            var countyNamesChecklist = GetCountriesNamesChecklist(dbCountryNames);

            var countriesNamesForRemoval = GetCountriesNamesForRemoval(countyNamesChecklist, countriesExternalDtos);
            countriesExternalDtos.RemoveAll(x => countriesNamesForRemoval.Contains(x.Name));

            var mergedCountriesPopulationList = countryDtos.Concat(countriesExternalDtos);

            return mergedCountriesPopulationList;
        }

        /// <summary>Gets the countries names checklist.</summary>
        /// <param name="dbCountryNames">The database country names.</param>
        /// <returns>The country names checklist.</returns>
        public List<string> GetCountriesNamesChecklist(List<string> dbCountryNames)
        {
            var countryNamesCheckList = new List<string>();
            countryNamesCheckList.AddRange(dbCountryNames);
            foreach (var dbCountryName in dbCountryNames)
            {
                var countryAliases = _countryNamesHelper.GetCountryAliases(dbCountryName);

                if (countryAliases.Count == 0) continue;

                countryNamesCheckList.AddRange(countryAliases);
            }
            return countryNamesCheckList;
        }

        /// <summary>Gets the countries names for removal.</summary>
        /// <param name="countyNamesChecklist">The county names checklist.</param>
        /// <param name="countriesExternalDtos">The countries external dtos.</param>
        /// <returns>The country names for removal list.</returns>
        public List<string> GetCountriesNamesForRemoval(List<string> countyNamesChecklist, List<CountryDto> countriesExternalDtos)
        {
            var countriesNamesForRemoval = new List<string>();
            foreach (var extCountry in countriesExternalDtos)
            {
                if (!countyNamesChecklist.Contains(extCountry.Name)) continue;

                countriesNamesForRemoval.Add(extCountry.Name);
            }
            return countriesNamesForRemoval;
        }

    }
}
