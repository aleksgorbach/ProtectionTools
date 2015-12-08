// Created 08.12.2015
// Modified by Александр 08.12.2015 at 21:17

namespace ProtectionTools.Core.Buses {
    #region References

    using System.Collections.Generic;
    using Elements;
    using Elements.Connections.Factory;
    using Elements.ElectroReceivers;
    using Elements.Groups;

    #endregion

    internal class SimpleBus : AbstractChainElement, IElementGroup {
        public SimpleBus(IConnectionFactory connectionFactory, int maxOutputCount)
            : base(connectionFactory) {
            MaxOutputsCount = maxOutputCount;
        }

        protected override int MaxOutputsCount { get; }
        public ICollection<IElectroReceiver> Elements { get; }
    }
}