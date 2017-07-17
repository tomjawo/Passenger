using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Passenger.Core.Domain;

namespace Passenger.Infrastructure.Repositories
{
    class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>
            {
                new Driver();

            };

        public Task AddAsync(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Driver>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
