using System;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Repositories;
using AutoMapper;
using Passenger.Core;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _autoMapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _autoMapper = mapper;

        }

        public async  Task<UserDto> GetAsync(string email)
        {
            var  user = await _userRepository.GetAsync(email);

            return  _autoMapper.Map<User, UserDto>(user);
        }

        public async Task RegisterAsync(string email,string username ,string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception("User with this email already exists.");
            }
            var salt = Guid.NewGuid().ToString("N");
            user = new Core.User(email, username, password,salt);

            await  _userRepository.AddAsync(user);


        }
    }
}
