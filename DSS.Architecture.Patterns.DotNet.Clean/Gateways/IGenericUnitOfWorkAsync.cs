using System.Threading.Tasks;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWorkAsync<TRepositoryType>
    {
        TRepositoryType GetRepository<TEntity>() where TEntity : class;
        Task Save();
    }
}
