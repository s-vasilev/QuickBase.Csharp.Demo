using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickBase.API.ApiModels.Request;
using QuickBase.API.ApiModels.Response;
using QuickBase.Business.Dtos;
using QuickBase.Business.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.API.Controllers
{
    /// <summary>Country Controller</summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="CountryController" /> class.</summary>
        /// <param name="countryService">The country service.</param>
        /// <param name="mapper">The mapper.</param>
        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        /// <summary>Gets all countries.</summary>
        /// <returns>A collection of country objects.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var countries = await _countryService.GetCountries();
            var response = _mapper.Map<IEnumerable<CountryResponse>>(countries);
            return Ok(response);
        }

        /// <summary>Gets all country populations.</summary>
        /// <returns>A collection of country population objects.</returns>
        [HttpGet("GetAllPopulations")]
        public async Task<IActionResult> GetAllPopulations()
        {
            var countriesPopulations = await _countryService.GetCountriesPopulations();
            var response = _mapper.Map<IEnumerable<CountryPopulationResponse>>(countriesPopulations);
            return Ok(response);
        }

        /// <summary>Creates a new country.</summary>
        /// <param name="request">The country object.</param>
        /// <returns>OK response.</returns>
        [HttpPost]
        public async Task<IActionResult> Post(CountryRequest request)
        {
            var country  = _mapper.Map<CountryDto>(request);
            await _countryService.AddCountry(country);
            return Ok();
        }

        /// <summary>Updates the country.</summary>
        /// <param name="request">The country object.</param>
        /// <returns>OK response.</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateCountry(CountryRequest request)
        {
            var country = _mapper.Map<CountryDto>(request);
            await _countryService.UpdateCountry(country);
            return Ok();
        }
    }
}
