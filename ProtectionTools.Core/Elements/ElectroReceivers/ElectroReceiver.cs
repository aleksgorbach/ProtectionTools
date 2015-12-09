// Created 09.12.2015
// Modified by  09.12.2015 at 15:18

namespace ProtectionTools.Core.Elements.ElectroReceivers {
    #region References

    using System;
    using Connections.Factory;

    #endregion

    internal class ElectroReceiver : AbstractChainElement, IElectroReceiver {
        public ElectroReceiver(IConnectionFactory connectionFactory, ConnectionType connectionType, double activePower,
            int count, double usingCoefficient,
            double cos) : base(connectionFactory) {
            ConnectionType = connectionType;
            ActivePower = activePower;
            Count = count;
            UsingCoefficient = usingCoefficient;
            Cos = cos;
            TotalNominalPower = Count*ActivePower;
            ReactiveLoad = TotalNominalPower*UsingCoefficient*Math.Tan(Math.Acos(Cos));
            MaxOutputsCount = Count;
        }

        protected override int MaxOutputsCount { get; }

        public ConnectionType ConnectionType { get; }
        public double ActivePower { get; }
        public int Count { get; }
        public double UsingCoefficient { get; }
        public double Cos { get; }
        public double TotalNominalPower { get; }
        public double ReactiveLoad { get; }
    }
}