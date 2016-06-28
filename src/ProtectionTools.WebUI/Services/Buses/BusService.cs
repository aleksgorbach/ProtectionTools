namespace ProtectionTools.WebAPI.Services.Buses {
    using Core.Buses;
    using Models.Buses;
    using Models.FusingTools.Fuses;
    using Models.FusingTools.Switchers;

    public class BusService : IBusService {
        private readonly IBusCalc _busCalcCore;

        public BusService(IBusCalc busCalCore) {
            _busCalcCore = busCalCore;
        }

        public double GetAmperage(Bus bus) {
            return _busCalcCore.GetAmperage(bus);
        }

        public Fuse GetMatchingFuse(Bus bus) {
            return _busCalcCore.GetMatchingFuse(bus);
        }

        public AutomaticSwitcher GetMatchingSwitcher(Bus bus) {
            return _busCalcCore.GetMatchingSwitcher(bus);
        }
    }
}