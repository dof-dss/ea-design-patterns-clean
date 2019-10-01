using System;
using System.Collections.Generic;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    /// <summary>
    /// An interface which defines the common members to work with a data store
    /// </summary>
    /// <typeparam name="TEntity">the type of object the repository wraps</typeparam>
    /// <typeparam name="TListType">the type of list objects to be returned</typeparam>
    public interface IGenericRepository<TEntity, TListType> 
        where TEntity : class
        where TListType : IEnumerable<TEntity>
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
        /// An IEnumerable of objects that represent all the objects in the data store.
        /// </returns>
        TListType GetAll();

        /// <summary>
        /// Finds matching objects for the specified filter criteria
        /// </summary>
        /// <param name="filter">a filter which defines the list of items to return</param>
        /// <returns>a list of objects</returns>
        TListType Find(Func<TEntity, bool> filter);
    }
}
