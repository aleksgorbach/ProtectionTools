namespace ProtectionTools.WebUI.Services {
    using System.Collections.Generic;
    using Core.Lines;

    public interface IBusService {
        double GetCurrent(double powerCoef, double nominalVoltage, IEnumerable<IConnectable> receivers);
    }
}