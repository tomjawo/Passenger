using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Passenger.Core;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>()
        {
          new User("user1@email.com","User1","secret","salt"),
          new User("User2@email.com","User2","secret","salt"),
          new User("User3@email.com","User3","secret","salt"),
          new User("User4@email.com","User4","secret","salt"),
          new User("User5@email.com","User5","secret","salt")
        };

        public async Task AddAsync(User user)
        {
            _users.Add(user);
        }

        public async Task<User> GetAsync(string email)
        {
             return _users.SingleOrDefault(x => x.Email == email.ToLowerInvariant());
        }

        public async Task<User> GetAsync(Guid id)
        {
            return _users.Single(x => x.Id == id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return _users;
        }

        public async Task RemoveAsync(Guid id)
        {
            var  user = await GetAsync(id);
            _users.Remove(user);
        }

        public async Task UpdateAsync(User user)
        {
           
        }

      
    }
}
