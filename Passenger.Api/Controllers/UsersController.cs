using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Services;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Commands.User;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService; 

        public UsersController(IUserService userservice)
        {
            _userService = userservice;   
        }

        // GET api/values/5
        [HttpGet("{email}")]
        public async  Task<UserDto> Get(string email)
        {
             return await _userService.GetAsync(email);
        
        }


        [HttpPost("")]
        public async Task Post([FromBody]CreateUser command)
        {
            await _userService.RegisterAsync(command.Email, command.Username, command.Password);

        }

    }
}
