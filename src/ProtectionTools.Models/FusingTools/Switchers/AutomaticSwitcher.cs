namespace ProtectionTools.Models.FusingTools.Switchers {
    public class AutomaticSwitcher : IEntity {
        public int Id { get; set; }
        public string Title { get; set; }
        public double DisablingAmperage { get; set; }
        public int[] AmperageFold { get; set; }
        public int PolesCount { get; set; }
    }
}