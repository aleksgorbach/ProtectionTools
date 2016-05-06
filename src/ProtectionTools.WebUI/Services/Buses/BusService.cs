namespace ProtectionTools.WebAPI.Services.Buses {
    using Core.Buses;
    using Models.Buses;

    public class BusService : IBusService {
        public double GetAmperage(Bus bus) {
            return BusCalc.GetAmperage(bus);
        }
    }
}