using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts;
using WebApp.Models;

namespace WebApp.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        private readonly IdentityContext _identity;

        protected GenericRepository(IdentityContext identity)
        {
            _identity = identity;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            _identity.Set<T>().Add(entity);
            await _identity.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await _identity.Set<T>().FirstOrDefaultAsync(predicate);
            return entity!;
        }
    }
}
