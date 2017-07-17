using System;
using System.Collections.Generic;
using System.Text;
using Passenger.Core.Domain;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Repositories
{
    interface IDriverRepository
    {
        Task<Driver> GetAsync(Guid Id);
        Task<IEnumerable<Driver>> GetAllAsync();
        Task AddAsync(Driver driver);
        Task UpdateAsync(Driver driver);
        Task RemoveAsync(Guid id);


    }
}
