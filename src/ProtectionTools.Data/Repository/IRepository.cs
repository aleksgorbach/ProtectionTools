namespace ProtectionTools.Data.Repository {
    #region References

    using System;
    using System.Linq;
    using Models;
    using Models.Engines;

    #endregion

    public interface IRepository<T> : IDisposable where T : class, IEntity {
        T Get(Predicate<T> condition);
        IQueryable<T> GetAll();
        Engine Add(T item);
        Engine Remove(int id);
    }
}