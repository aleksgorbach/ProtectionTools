// Created 08.12.2015
// Modified by  09.12.2015 at 15:18

namespace ProtectionTools.Core.Elements.ElectroReceivers {
    using System;

    public enum ConnectionType {
        ThreePhase
    }

    public interface IElectroReceiver {
        ConnectionType ConnectionType { get; }

        /// <summary>
        /// Номинальная активная мощность
        /// </summary>
        double ActivePower { get; }

        int Count { get; }

        /// <summary>
        /// Коэффициент использования
        /// </summary>
        double UsingCoefficient { get; }

        double Cos { get; }

        /// <summary>
        /// Общая номинальная мощность
        /// </summary>
        double TotalNominalPower { get; }

        /// <summary>
        /// Расчетная реактивная мощность
        /// </summary>
        double ReactiveLoad { get; }

        Guid Id { get; }
    }
}