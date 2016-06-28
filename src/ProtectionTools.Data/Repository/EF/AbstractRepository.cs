namespace ProtectionTools.Data.Repository.EF {
    using System;
    using System.Linq;
    using Microsoft.Data.Entity;
    using Models;

    public abstract class AbstractRepository<T> : IRepository<T> where T : class, IEntity {
        protected readonly DataContext Context;
        private bool _disposed;

        protected AbstractRepository(DataContext context) {
            Context = context;
        }

        public T Get(Predicate<T> condition) {
            return Set.FirstOrDefault();
        }

        public IQueryable<T> GetAll() {
            return Set.AsQueryable();
        }

        public T Add(T item) {
            Set.Add(item);
            Context.SaveChanges();
            return item;
        }

        public T Remove(int id) {
            var item = Set.SingleOrDefault(x => x.Id == id);
            if (item == null) {
                return null;
            }
            Set.Remove(item);
            Context.SaveChanges();
            return item;
        }

        protected virtual void Dispose(bool disposing) {
            if (!_disposed) {
                if (disposing) {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract DbSet<T> Set { get; }
    }
}