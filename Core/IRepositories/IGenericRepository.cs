namespace RepositoryInit.Core.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetById(int id);

        Task<bool> Add(T entity);

    }
}
