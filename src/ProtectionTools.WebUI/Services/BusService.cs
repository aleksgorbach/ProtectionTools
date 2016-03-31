namespace ProtectionTools.WebUI.Services {
    using System.Collections.Generic;
    using Core.Buses;
    using Core.Elements.Connections.Factory;
    using Core.Lines;

    internal class BusService : IBusService {
        private readonly IConnectionFactory _connectionFactory;
        private readonly int _maxOutputCount;

        public BusService(IConnectionFactory connectionFactory, int maxOutputCount = 10) {
            _connectionFactory = connectionFactory;
            _maxOutputCount = maxOutputCount;
        }

        public double GetCurrent(double powerCoef, double nominalVoltage, IEnumerable<IConnectable> receivers) {
            var bus = new SimpleBus(_connectionFactory, _maxOutputCount, powerCoef, nominalVoltage);
            foreach (var receiver in receivers) {
                bus.ConnectOutput(receiver);
            }
            return bus.Amperage;
        }
    }
}