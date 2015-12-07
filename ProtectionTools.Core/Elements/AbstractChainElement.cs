// Created 07.12.2015
// Modified by  07.12.2015 at 15:03

namespace ProtectionTools.Core.Elements {
    #region References

    using System.Collections.Generic;
    using System.Linq;
    using Connections;
    using Connections.Factory;
    using Lines;

    #endregion

    internal abstract class AbstractChainElement : IChainElement {
        private readonly IConnectionFactory _connectionFactory;
        private readonly List<IConnection> _connections;

        protected AbstractChainElement(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
            _connections = new List<IConnection>();
        }

        public ILine Connect(IConnectable element) {
            var connection = _connections.FirstOrDefault(x => x.Element == element);
            if (connection == null) {
                connection = _connectionFactory.Create(element);
                _connections.Add(connection);
            }
            return connection.Line;
        }

        public IEnumerable<IConnection> Connections => _connections;
    }
}