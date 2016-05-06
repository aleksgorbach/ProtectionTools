namespace ProtectionTools.Data.Repository.EF {
    using System;
    using System.Linq;
    using Models.Engines;

    public class EnginesRepository : IRepository<Engine> {
        private readonly DataContext _context;
        private bool _disposed;

        public EnginesRepository(DataContext context) {
            _context = context;
        }

        public Engine Get(Predicate<Engine> condition) {
            return _context.Engines.FirstOrDefault();
        }

        public IQueryable<Engine> GetAll() {
            return _context.Engines.AsQueryable();
        }

        public void Add(Engine item) {
            _context.Engines.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Engine item) {
            _context.Engines.Remove(item);
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