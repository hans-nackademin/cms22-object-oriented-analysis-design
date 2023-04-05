using _01_SRP.Contexts;
using _01_SRP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _01_SRP.Repositories
{
    public class UserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> CreateAsync(UserEntity entity) 
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<UserEntity> GetAsync(Expression<Func<UserEntity, bool>> predicate)
        {
            var entity = await _context.Users.FirstOrDefaultAsync(predicate);
            return entity!;
        }

        public async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
