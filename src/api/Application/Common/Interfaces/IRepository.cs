using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task SaveChangesAsync();
    }
}