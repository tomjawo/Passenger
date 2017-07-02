using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Passenger.Core;


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

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(string email)
        {
             return _users.Single(x => x.Email == email.ToLowerInvariant());
        }
            public User Get(Guid id)
        {
            return _users.Single(x => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
           
        }
    }
}
