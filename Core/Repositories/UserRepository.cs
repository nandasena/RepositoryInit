using Microsoft.EntityFrameworkCore;
using RepositoryInit.Core.IRepositories;
using RepositoryInit.Data;
using RepositoryInit.Models;

namespace RepositoryInit.Core.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        //protected DbSet<User> dbSet;
        public UserRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<User>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"{Repo} All Method error", typeof(UserRepository));
                return new List<User>();
            }
        }

        public  async Task<bool> UpDate(User entity)
        {

            try
            {
                var exsistingUser = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (exsistingUser == null)
                {
                    return await Add(entity);
                }

                exsistingUser.USERNAME = entity.USERNAME;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"{repo} upDate method error",typeof(UserRepository));
                return false;
            }
        }



    }
}
