using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickBase.API.ApiModels.Response;
using QuickBase.Business.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.API.Controllers
{
    /// <summary>State Controller.</summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _stateService;
        
        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="StateController" /> class.</summary>
        /// <param name="stateService">The state service.</param>
        /// <param name="mapper">The mapper.</param>
        public StateController(IStateService stateService, IMapper mapper)
        {
            _stateService = stateService;
            _mapper = mapper;
        }

        /// <summary>Gets all states.</summary>
        /// <returns>A collection of states.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var states = await _stateService.GetStates();
            var response = _mapper.Map<IEnumerable<StateResponse>>(states);
            return Ok(response);
        }
    }
}
