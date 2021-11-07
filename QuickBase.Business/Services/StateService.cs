using AutoMapper;
using QuickBase.Business.Dtos;
using QuickBase.Business.Interfaces.Services;
using QuickBase.Business.Interfaces.SqliteData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Services
{
    /// <summary>The state service implementation.</summary>
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _uow;

        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="StateService" /> class.</summary>
        /// <param name="uow">The uow.</param>
        /// <param name="mapper">The mapper.</param>
        public StateService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>Gets the states.</summary>
        /// <returns>The states.</returns>
        public async Task<IEnumerable<StateDto>> GetStates()
        {
            var states = await _uow.States.GetStates();
            var statesDtos = _mapper.Map<IEnumerable<StateDto>>(states);
            return statesDtos;
        }
    }
}
