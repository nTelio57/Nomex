using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Data;
using Nomex.Dtos.UserPersonal;
using Nomex.Models;

namespace Nomex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPersonalController : ControllerBase
    {
        private readonly IUserPersonalRepo _repository;
        private readonly IMapper _mapper;

        public UserPersonalController(IUserPersonalRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserPersonalReadDto>> GetAllUserPersonals()
        {
            var userPersonalItems = _repository.GetAllUserPersonals();
            return Ok(_mapper.Map<IEnumerable<UserPersonalReadDto>>(userPersonalItems));
        }

        [HttpGet("{id}", Name = "GetUserPersonalById")]
        public ActionResult<UserPersonalReadDto> GetUserPersonalById(int id)
        {
            var userPersonalItem = _repository.GetUserPersonalById(id);
            if (userPersonalItem == null)
                return NotFound();

            return Ok(_mapper.Map<UserPersonalReadDto>(userPersonalItem));
        }

        [HttpPost]
        public ActionResult<UserPersonalCreateDto> CreateUserPersonal(UserPersonalCreateDto userPersonalCreateDto)
        {
            var userPersonalModel = _mapper.Map<UserPersonal>(userPersonalCreateDto);

            _repository.CreateUserPersonal(userPersonalModel);
            _repository.SaveChanges();

            var userPersonalReadDto = _mapper.Map<UserPersonalReadDto>(userPersonalModel);

            return CreatedAtRoute(nameof(GetUserPersonalById), new {Id = userPersonalReadDto.Id}, userPersonalReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUserPersonal(int id, UserPersonalUpdateDto userPersonalUpdateDto)
        {
            var userPersonalFromRepo = _repository.GetUserPersonalById(id);
            if (userPersonalFromRepo == null)
                return NotFound();

            _mapper.Map(userPersonalUpdateDto, userPersonalFromRepo);
            _repository.UpdateUserPersonal(userPersonalFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUserPersonal(int id)
        {
            var userPersonalFromRepo = _repository.GetUserPersonalById(id);
            if (userPersonalFromRepo == null)
                return NotFound();

            _repository.DeleteUserPersonal(userPersonalFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
