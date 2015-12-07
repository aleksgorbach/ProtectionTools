// Created 07.12.2015
// Modified by Александр 07.12.2015 at 21:16

namespace ProtectionTools.Core.Elements.ElectroReceivers {
    public enum ConnectionType {
        ThreePhase
    }

    internal interface IElectroReceiver {
        ConnectionType ConnectionType { get; }
        double ActivePower { get; }
        int Count { get; }
        double UsingCoefficient { get; }
        double Cos { get; }
    }
}