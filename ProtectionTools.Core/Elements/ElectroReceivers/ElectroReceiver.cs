namespace ProtectionTools.Core.Elements.ElectroReceivers {
    #region References

    using System;
    using Connections.Factory;

    #endregion

    public class ElectroReceiver : AbstractChainElement, IElectroReceiver {
        public ElectroReceiver(IConnectionFactory connectionFactory, double activePower,
            int count, double usingCoefficient,
            double cos) : base(connectionFactory) {
            ActivePower = activePower;
            Count = count;
            UsingCoefficient = usingCoefficient;
            Cos = cos;
            TotalNominalPower = Count*ActivePower;
            ReactiveLoad = TotalNominalPower*UsingCoefficient*Math.Tan(Math.Acos(Cos));
            MaxOutputsCount = Count;
        }

        protected override int MaxOutputsCount { get; }

        public double ActivePower { get; set; }
        public int Count { get; set; }
        public double UsingCoefficient { get; set; }
        public double Cos { get; set; }
        public double TotalNominalPower { get; set; }
        public double ReactiveLoad { get; set; }
    }
}