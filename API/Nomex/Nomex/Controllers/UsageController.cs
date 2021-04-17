using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Data;
using Nomex.Dtos.Usage;

namespace Nomex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsageController : ControllerBase
    {
        private readonly IUsageRepo _repository;
        private readonly IMapper _mapper;

        public UsageController(IUsageRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsageReadDto>> GetAllUsages()
        {
            var usageItems = _repository.GetAllUsages();
            return Ok(_mapper.Map<IEnumerable<UsageReadDto>>(usageItems));
        }
    }
}
