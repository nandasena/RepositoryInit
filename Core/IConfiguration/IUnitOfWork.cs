using RepositoryInit.Core.IRepositories;

namespace RepositoryInit.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}
