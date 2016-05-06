using ProtectionTools.Models.Buses;

namespace ProtectionTools.WebAPI.Services.Buses {
    public interface IBusService {
        double GetAmperage(Bus bus);
    }
}