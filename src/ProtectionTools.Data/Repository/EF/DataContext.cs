namespace ProtectionTools.Data.Repository.EF {
    #region References

    using Microsoft.Data.Entity;
    using Models.Engines;
    using Models.FusingTools.Switchers;

    #endregion

    public class DataContext : DbContext {
        public DbSet<Engine> Engines { get; set; }
        public DbSet<AutomaticSwitcher> Switchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Engine>().HasKey(e => e.Id);
            modelBuilder.Entity<AutomaticSwitcher>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}