using System;
using EventManager.Contract.BaseClasses;

namespace EventManager.Contract
{
    public interface IRepository<T> where T : BaseEntity
    {
        void SaveOrUpdate(T item);

        void Delete(T item);

        T GetItemById(Guid Id);

    }
}