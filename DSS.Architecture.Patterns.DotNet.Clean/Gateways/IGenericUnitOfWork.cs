namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWork
    {
        TRepositoryType GetRepository<TRepositoryType, TEntity>() where TEntity : class;
        void Save();
    }
}
