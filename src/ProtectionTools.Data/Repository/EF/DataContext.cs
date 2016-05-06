namespace ProtectionTools.Data.Repository.EF {
    #region References

    using Microsoft.Data.Entity;
    using Models.Engines;

    #endregion

    public class DataContext : DbContext {
        public DbSet<Engine> Engines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Engine>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}