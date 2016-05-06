namespace ProtectionTools.Data.Repository.EF {
    using System;
    using System.Linq;
    using Microsoft.Data.Entity;

    public class EFRepository<T> : IRepository<T> where T : class {
        private readonly DbContext _context;
        private bool _disposed;

        public EFRepository(DbContext context) {
            _context = context;
        }

        public T Get(Predicate<T> condition) {
            return _context.Set<T>().FirstOrDefault();
        }

        public IQueryable<T> GetAll() {
            return _context.Set<T>();
        }

        public void Add(T item) {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Remove(T item) {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing) {
            if (!_disposed) {
                if (disposing) {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}