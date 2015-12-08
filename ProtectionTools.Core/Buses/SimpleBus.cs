// Created 08.12.2015
// Modified by  08.12.2015 at 14:14

namespace ProtectionTools.Core.Buses {
    #region References

    using Elements;
    using Elements.Connections.Factory;

    #endregion

    internal class SimpleBus : AbstractChainElement {
        public SimpleBus(IConnectionFactory connectionFactory, int maxOutputCount)
            : base(connectionFactory) {
            MaxOutputsCount = maxOutputCount;
        }

        protected override int MaxOutputsCount { get; }
    }
}