namespace ProtectionTools.Data.Repository {
    #region References

    using System;
    using System.Linq;
    using Models;

    #endregion

    public interface IRepository<T> : IDisposable where T : class, IEntity {
        T Get(Predicate<T> condition);
        IQueryable<T> GetAll();
        T Add(T item);
        T Remove(int id);
    }
}