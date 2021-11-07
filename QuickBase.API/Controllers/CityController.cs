using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickBase.API.ApiModels.Response;
using QuickBase.Business.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBase.API.Controllers
{
    /// <summary>City Controller</summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="CityController" /> class.</summary>
        /// <param name="cityService">The city service.</param>
        /// <param name="mapper">The mapper.</param>
        public CityController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        /// <summary>Gets all cities.</summary>
        /// <returns>A collection of city objects.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cities = await _cityService.GetCities();
            var response = _mapper.Map<IEnumerable<CityResponse>>(cities);
            return Ok(response.ToList().Take(100));
        }
    }
}
