using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Data;
using Nomex.Dtos;
using Nomex.Models;
using Nomex.Utilities;

namespace Nomex.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepo _repository;
        private readonly IMapper _mapper;
        public AuthController(IAuthRepo jwtAuthenticationRepo, IMapper mapper)
        {
            _repository = jwtAuthenticationRepo;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public ActionResult Register(AuthRequest authRequest)
        {
            var existingUser = _repository.GetUserByEmail(authRequest.Email);

            if (existingUser != null)
            {
                return BadRequest(new AuthResult
                {
                    Errors = new[] {"User with this email address already exists"}
                });
            }

            var newUser = new User
            {
                Email = authRequest.Email,
                Password = Crypto.Hash(authRequest.Password),
                Salt = Crypto.GenerateSalt()
            };

            _repository.AddNewUser(newUser);
            _repository.SaveChanges();

            var token = _repository.GenerateToken(authRequest.Email);
            return Ok(new AuthResult
            {
                Success = true,
                Token = token,
                User = _mapper.Map<UserReadDto>(newUser)
            });
        }

        [HttpPost("login")]
        public ActionResult Login(AuthRequest authRequest)
        {
            var existingUser = _repository.GetUserByLogin(authRequest.Email, authRequest.Password);

            if (existingUser == null)
            {
                return BadRequest(new AuthResult
                {
                    Errors = new[] { "Wrong credentials" }
                });
            }

            var token = _repository.GenerateToken(authRequest.Email);
            return Ok(new AuthResult
            {
                Success = true,
                Token = token,
                User = _mapper.Map<UserReadDto>(existingUser)
            });
        }

    }
}
