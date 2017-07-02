﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Services;
using Passenger.Infrastructure.DTO;

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
        public UserDto Get(string email)
        {
            return _userService.Get(email);
        }
        
    }
}
