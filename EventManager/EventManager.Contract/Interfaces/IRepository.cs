// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Dotnet Usergroup Hamburg">
//   2012
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using EventManager.Contract.BaseClasses;

namespace EventManager.Contract
{
    /// <summary>
    /// The i repository.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// The save or update.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void SaveOrUpdate(T item);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Delete(T item);

        /// <summary>
        /// The get item by id.
        /// </summary>
        /// <param name="Id">
        /// The id.
        /// </param>
        /// <returns>
        /// </returns>
        T GetItemById(Guid Id);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// A Enumerable of T
        /// </returns>
        IEnumerable<T> GetAll();
    }
}