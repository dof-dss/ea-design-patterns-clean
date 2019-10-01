namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    public interface IGenericUnitOfWork<ç>
    {
        TRepositoryType GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}
