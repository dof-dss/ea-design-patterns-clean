using System.Threading.Tasks;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWorkAsync
    {
        TRepositoryType GetRepository<TRepositoryType, TEntity>() where TEntity : class;
        Task Save();
    }
}
