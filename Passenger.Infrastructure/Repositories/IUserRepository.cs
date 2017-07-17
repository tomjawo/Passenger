using System;
using System.Collections.Generic;
using System.Text;
using Passenger.Core;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User>  GetAsync(string email);             
        Task<User> GetAsync(Guid id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task RemoveAsync(Guid id);
    }
}
