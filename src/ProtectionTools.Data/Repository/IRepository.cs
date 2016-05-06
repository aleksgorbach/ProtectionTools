namespace ProtectionTools.Data.Repository {
    #region References

    using System;
    using System.Linq;

    #endregion

    public interface IRepository<T> : IDisposable {
        T Get(Predicate<T> condition);
        IQueryable<T> GetAll();
        void Add(T item);
        void Remove(T item);
    }
}