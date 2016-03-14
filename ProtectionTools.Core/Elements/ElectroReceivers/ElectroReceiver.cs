// Created 09.12.2015
// Modified by  09.12.2015 at 15:18

namespace ProtectionTools.Core.Elements.ElectroReceivers {
    #region References

    using System;
    using Connections.Factory;

    #endregion

    public class ElectroReceiver : AbstractChainElement, IElectroReceiver {
        public ElectroReceiver(IConnectionFactory connectionFactory, ConnectionType connectionType, double activePower,
            int count, double usingCoefficient,
            double cos) : base(connectionFactory) {
            ConnectionType = connectionType;
            ActivePower = activePower;
            Count = count;
            UsingCoefficient = usingCoefficient;
            Cos = cos;
            Id = Guid.NewGuid();
            TotalNominalPower = Count*ActivePower;
            ReactiveLoad = TotalNominalPower*UsingCoefficient*Math.Tan(Math.Acos(Cos));
            MaxOutputsCount = Count;
        }

        protected override int MaxOutputsCount { get; }
        public Guid Id { get; }

        public ConnectionType ConnectionType { get; set; }
        public double ActivePower { get; set; }
        public int Count { get; set; }
        public double UsingCoefficient { get; set; }
        public double Cos { get; set; }
        public double TotalNominalPower { get; set; }
        public double ReactiveLoad { get; set; }
    }
}