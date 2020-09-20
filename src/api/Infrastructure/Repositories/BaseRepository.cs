using System.Threading.Tasks;
using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> where TEntity : class, IRepository<TEntity>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _set;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }
        public async Task<TEntity> GetById(int id)
        {
            return await _set.FindAsync(id);
        }

        public async Task Create(TEntity entity)
        {
            await _set.AddAsync(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}