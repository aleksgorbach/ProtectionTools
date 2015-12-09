// Created 09.12.2015
// Modified by  09.12.2015 at 15:23

namespace ProtectionTools.Core.Elements.Groups {
    internal interface IElementGroup {
        //ICollection<IElectroReceiver> Elements { get; }
        /// <summary>
        /// Расчетная реактивная мощность
        /// </summary>
        double CountedReactivePower { get; }

        /// <summary>
        /// Расчетная активная мощность
        /// </summary>
        double CountedActivePower { get; }

        /// <summary>
        /// Расчетная токовая нагрузка
        /// </summary>
        double Amperage { get; }

        /// <summary>
        /// Полная расчетная мощность узла
        /// </summary>
        double TotalCountedPower { get; }
    }
}