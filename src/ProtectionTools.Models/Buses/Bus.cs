namespace ProtectionTools.Models.Buses {
    using System.Collections.Generic;

    public class Bus {
        public double Voltage { get; set; }
        public double PowerCoef { get; set; }
        public List<ElectricElement> Elements { get; set; }
        public double Power { get; set; }
    }
}