namespace ProtectionTools.Models.Engines {
    public class Engine : IEntity {
        public int Id { get; set; }
        public string Title { get; set; }
        public double TurnsPerMin { get; set; }
        public double IpIn { get; set; }
        public double Power { get; set; }
        public double Amperage { get; set; }
        public double PowerCoef { get; set; }
    }
}