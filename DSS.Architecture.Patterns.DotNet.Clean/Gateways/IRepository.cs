using System;
using System.Collections.Generic;
using System.Linq;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    /// <summary>
    /// An interface which defines the common members to work with a data store
    /// </summary>
    /// <typeparam name="TEntity">the type of object the repository wraps</typeparam>
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        /// <summary>
        /// Creates a new object in the data store.
        /// </summary>
        /// <param name="obj">The object to create within the data store.</param>
        void Create(TEntity obj);

        /// <summary>
        /// Deletes an object from the data store.
        /// </summary>
        /// <param name="id">The ID of the object to remove.</param>
        void Delete(int id);

        /// <summary>
        /// Edits an object in the data store.
        /// </summary>
        /// <param name="obj">The object to edit in the data store.</param>
        void Edit(TEntity obj);

        /// <summary>
        /// Gets an object from the data store.
        /// </summary>
        /// <param name="id">The ID of the object to return from the data store.</param>
        /// <returns>The object matching the specified ID from the data store, or null if none exists.</returns>
        TEntity Get(int id);

        /// <summary>
        /// Gets all the objects from the data store.
        /// </summary>
        /// <returns>
        /// An IQueryable of objects that represent all the objects in the data store.
        /// </returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Finds matching objects for the specified filter criteria
        /// </summary>
        /// <param name="filter">a filter which defines the list of items to return</param>
        /// <returns>a list of objects</returns>
        IQueryable<TEntity> Find(Func<TEntity, bool> filter);
    }
}
