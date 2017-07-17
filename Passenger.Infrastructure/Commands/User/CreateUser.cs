using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastructure.Commands.User
{
    public class CreateUser : ICommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
