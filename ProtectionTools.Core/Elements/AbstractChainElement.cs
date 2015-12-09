// Created 07.12.2015
// Modified by  09.12.2015 at 14:56

namespace ProtectionTools.Core.Elements {
    #region References

    using System.Collections.Generic;
    using System.Linq;
    using Connections;
    using Connections.Factory;
    using Exceptions.Connections;
    using Lines;

    #endregion

    public abstract class AbstractChainElement : IConnectable {
        private const int MAX_INPUTS = 1;
        private const int MAX_OUTPUTS = 1;
        private readonly IConnectionFactory _connectionFactory;
        private readonly List<IConnection> _inputConnections;
        private readonly List<IConnection> _outputConnections;

        protected AbstractChainElement(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
            MaxInputsCount = MAX_INPUTS;
            MaxOutputsCount = MAX_OUTPUTS;
            _inputConnections = new List<IConnection>();
            _outputConnections = new List<IConnection>();
        }

        protected virtual int MaxInputsCount { get; }
        protected virtual int MaxOutputsCount { get; }

        public ICollection<IConnection> InConnections => _inputConnections;

        public ICollection<IConnection> OutConnections => _outputConnections;

        #region Connections management

        public IConnection ConnectInput(IConnectable element) {
            if (_inputConnections.Count == MaxInputsCount) {
                throw new ElementInputBusyException(this, element);
            }
            var connection = _connectionFactory.Create(element);
            _inputConnections.Add(connection);
            return connection;
        }

        public IConnection ConnectOutput(IConnectable element) {
            if (_outputConnections.Count == MaxOutputsCount) {
                throw new ElementOutputBusyException(this, element);
            }
            var connection = _connectionFactory.Create(element);
            _outputConnections.Add(connection);
            return connection;
        }

        public void DisconnectInput(IConnectable element) {
            RemoveConnection(_inputConnections, element);
        }

        public void DisconnectOutput(IConnectable element) {
            RemoveConnection(_outputConnections, element);
        }

        private void RemoveConnection(ICollection<IConnection> source, IConnectable element) {
            var connection = source.FirstOrDefault(x => x.Element == element);
            if (connection == null) {
                throw new ConnectionMissingException(this, element);
            }
            source.Remove(connection);
        }

        #endregion
    }
}