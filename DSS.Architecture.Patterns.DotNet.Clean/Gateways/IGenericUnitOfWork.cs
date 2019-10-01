namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWork<TRepositoryType>
    {
        TRepositoryType GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}
