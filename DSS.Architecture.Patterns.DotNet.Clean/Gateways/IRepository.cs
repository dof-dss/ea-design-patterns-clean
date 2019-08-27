using System;
using System.Collections.Generic;
using System.Text;

namespace DSS.Architecture.Patterns.DotNet.Clean.Gateways
{
    /// <summary>
    /// An interface which defines the common members to work with a data store
    /// </summary>
    /// <typeparam name="T">the type of object the repository wraps</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Creates a new object in the data store.
        /// </summary>
        /// <param name="obj">The object to create within the data store.</param>
        void Create(T obj);

        /// <summary>
        /// Deletes an object from the data store.
        /// </summary>
        /// <param name="id">The ID of the object to remove.</param>
        void Delete(int id);

        /// <summary>
        /// Edits an object in the data store.
        /// </summary>
        /// <param name="obj">The object to edit in the data store.</param>
        void Edit(T obj);

        /// <summary>
        /// Gets an object from the data store.
        /// </summary>
        /// <param name="id">The ID of the object to return from the data store.</param>
        /// <returns>The object matching the specified ID from the data store, or null if none exists.</returns>
        T Get(int id);

        /// <summary>
        /// Gets all the objects from the data store.
        /// </summary>
        /// <returns>
        /// An IEnumerable of objects that represent all the objects in the data store.
        /// </returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Finds matching objects for the specified filter criteria
        /// </summary>
        /// <param name="filter">a filter which defines the list of items to return</param>
        /// <returns>an <see cref="IEnumerable{T}"/> of objects</returns>
        IEnumerable<T> Find(Func<T, bool> filter);
    }
}
