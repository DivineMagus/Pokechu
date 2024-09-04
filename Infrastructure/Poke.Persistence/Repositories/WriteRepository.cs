using Microsoft.EntityFrameworkCore;
using Poke.Application.Interfaces.Repositories;
using Poke.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;

        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public Task<int> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddRangeAsync(IList<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> HardDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> SoftDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
