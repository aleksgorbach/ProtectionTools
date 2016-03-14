// Created 07.12.2015
// Modified by  07.12.2015 at 15:03

namespace ProtectionTools.Core.Elements.Connections.Factory {
    #region References

    using Lines;
    using Lines.Factories;

    #endregion

    public class ConnectionFactory : IConnectionFactory {
        private readonly ILineFactory _lineFactory;

        public ConnectionFactory(ILineFactory lineFactory) {
            _lineFactory = lineFactory;
        }

        public IConnection Create(IConnectable element) {
            var line = _lineFactory.Create();
            return new Connection(element, line);
        }
    }
}