using System.Threading.Tasks;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IUnitOfWorkAsync
    {
        IRepositoryAsync<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task Save();
    }
}
