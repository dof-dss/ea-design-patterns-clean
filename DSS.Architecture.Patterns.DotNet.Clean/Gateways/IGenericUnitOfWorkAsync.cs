using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWorkAsync
    {
        IGenericRepositoryAsync<TEntity, TListType> GetRepository<TEntity, TListType>()
            where TEntity : class
            where TListType : IEnumerable<TEntity>;
        Task Save();
    }
}
