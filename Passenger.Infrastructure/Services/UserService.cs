﻿using System;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Repositories;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository; 

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);
            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                FullName = user.FullName
            };
        }

        public void Register(string email,string username ,string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception("User with this email already exists.");
            }
            var salt = Guid.NewGuid().ToString("N");
            user = new Core.User(email, username, password,salt);
            _userRepository.Add(user);


        }
    }
}
