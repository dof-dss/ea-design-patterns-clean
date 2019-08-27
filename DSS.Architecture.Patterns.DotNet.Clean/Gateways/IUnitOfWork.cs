using System;
using System.Collections.Generic;
using System.Text;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}
