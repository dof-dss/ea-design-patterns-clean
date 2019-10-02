using System.Collections.Generic;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWork
    {
        IGenericRepository<TEntity, TListType> GetRepository<TEntity, TListType>()
            where TEntity : class
            where TListType : IEnumerable<TEntity>;
        void Save();
    }
}
