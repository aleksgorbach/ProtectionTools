namespace ProtectionTools.Core.Buses {
    using System;
    using System.Linq;
    using Data.Repository;
    using Models.Buses;
    using Models.Engines;
    using Models.FusingTools.Fuses;
    using Models.FusingTools.Switchers;

    public class BusCalc : IBusCalc {
        private readonly IRepository<Engine> _engineRepository;
        private readonly IRepository<AutomaticSwitcher> _switcherRepository;

        public BusCalc(IRepository<Engine> engineRepository, IRepository<AutomaticSwitcher> switcherRepository) {
            _engineRepository = engineRepository;
            _switcherRepository = switcherRepository;
        }

        // расчетный ток
        public double GetAmperage(Bus bus) {
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

        // пусковой ток
        private double GetStartAmperage(Bus bus) {
            return GetAmperage(bus) * _engineRepository.GetAll()
                .Where(engine => engine.Power > bus.Power)
                .Min(engine => engine.IpIn);
        }

        public Fuse GetMatchingFuse(Bus bus) {
            throw new NotImplementedException();
        }

        public AutomaticSwitcher GetMatchingSwitcher(Bus bus) {
            var amperage = GetAmperage(bus);
            var startAmperage = GetStartAmperage(bus);
            var switcher =
                _switcherRepository
                    .GetAll(
                    ).FirstOrDefault(s => s.DisablingAmperage >= amperage &&
                                          s.AmperageFold.Any(x => x * s.DisablingAmperage >= 1.25 * startAmperage));
            return switcher;
        }
    }
}