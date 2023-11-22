using RepositoryInit.Core.IConfiguration;
using RepositoryInit.Core.IRepositories;
using RepositoryInit.Core.Repositories;

namespace RepositoryInit.Data
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly ApplicationDbContext _conetext;

        private readonly ILogger _logger;

        public IUserRepository Users { get; private set; }


        public UnitOfWork(ApplicationDbContext conetext, ILoggerFactory loggerFactory)
        {
            _conetext = conetext;
            _logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(_conetext,_logger);
        }

        public async Task CompleteAsync()
        {
            await _conetext.SaveChangesAsync();
        }


        public async void Dispose()
        {
             _conetext.Dispose();
        }
    }
}
