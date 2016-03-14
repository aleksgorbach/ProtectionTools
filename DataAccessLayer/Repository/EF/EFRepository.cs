namespace DataAccessLayer.Repository.EF {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFRepository<T> : IRepository<T> where T : class {
        private readonly DbContext _context;

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
    }
}