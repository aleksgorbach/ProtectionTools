namespace ProtectionTools.Data.Repository.EF.Impl {
    using Microsoft.Data.Entity;
    using Models.FusingTools.Switchers;

    public class SwitchersRepository : AbstractRepository<AutomaticSwitcher> {
        public SwitchersRepository(DataContext context) : base(context) {
        }

        protected override DbSet<AutomaticSwitcher> Set {
            get { return Context.Switchers; }
        }
    }
}