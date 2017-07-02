using System;
using System.Collections.Generic;
using System.Text;
using Passenger.Core;

namespace Passenger.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        User Get(string email);
        User Get(Guid id);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Remove(Guid id);
    }
}
