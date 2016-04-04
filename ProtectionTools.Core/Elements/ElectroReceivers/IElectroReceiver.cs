namespace ProtectionTools.Core.Elements.ElectroReceivers {
    public interface IElectroReceiver {
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
    }
}