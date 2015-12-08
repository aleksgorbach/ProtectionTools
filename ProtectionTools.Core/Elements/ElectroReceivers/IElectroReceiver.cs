// Created 07.12.2015
// Modified by Александр 08.12.2015 at 21:13

namespace ProtectionTools.Core.Elements.ElectroReceivers {
    public enum ConnectionType {
        ThreePhase
    }

    public interface IElectroReceiver {
        ConnectionType ConnectionType { get; }
        double ActivePower { get; }
        int Count { get; }
        double UsingCoefficient { get; }
        double Cos { get; }
        double TotalNominalPower { get; }
        double ReactiveLoad { get; }
    }
}