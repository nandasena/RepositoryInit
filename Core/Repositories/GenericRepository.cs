using Microsoft.EntityFrameworkCore;
using RepositoryInit.Core.IRepositories;
using RepositoryInit.Data;

namespace RepositoryInit.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected ApplicationDbContext _context;

        protected DbSet<T> dbSet;

        protected readonly ILogger _logger;


        public GenericRepository(ApplicationDbContext context,  ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = context.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }


    }
}
