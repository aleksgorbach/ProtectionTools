namespace ProtectionTools.Data.Repository.EF.Impl {
    using Microsoft.Data.Entity;
    using Models.Engines;

    public class EnginesRepository : AbstractRepository<Engine> {
        public EnginesRepository(DataContext context) : base(context) {
        }

        protected override DbSet<Engine> Set {
            get { return Context.Engines; }
        }
    }
}