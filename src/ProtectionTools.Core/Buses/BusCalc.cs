namespace ProtectionTools.Core.Buses {
    using System;
    using System.Linq;
    using Models.Buses;

    public class BusCalc {
        public static double GetAmperage(Bus bus) {
            var coef = bus.Elements.Count <= 10 ? 1.1 : 1.0;
            var activePower = bus.PowerCoef *
                              bus.Elements.Sum(elem => elem.Count * elem.ActivePower * elem.UsingCoefficient);
            var reactivePower = coef *
                                bus.Elements.Sum(
                                    elem =>
                                        elem.Count * elem.ActivePower * elem.UsingCoefficient *
                                        Math.Tan(Math.Acos(elem.Cos)));
            var totalPower = Math.Sqrt(activePower * activePower + reactivePower * reactivePower);
            return totalPower / (Math.Sqrt(3) * bus.Voltage);
        }
    }
}