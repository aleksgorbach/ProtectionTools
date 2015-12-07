// Created 07.12.2015
// Modified by Александр 07.12.2015 at 21:08

namespace DataAccessLayer.Repository {
    #region References

    using System;
    using System.Linq;

    #endregion

    public interface IRepository<T> {
        T Get(Predicate<T> condition);
        IQueryable<T> GetAll();
        void Add(T item);
        void Remove(T item);
    }
}