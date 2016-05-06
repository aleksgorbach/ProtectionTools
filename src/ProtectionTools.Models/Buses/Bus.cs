namespace ProtectionTools.Models.Buses {
    using System.Collections.Generic;

    public class Bus {
        public double Voltage;
        public double PowerCoef;
        public List<ElectricElement> Elements;
    }
}