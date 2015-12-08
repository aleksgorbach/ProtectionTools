// Created 08.12.2015
// Modified by Александр 08.12.2015 at 21:12

namespace ProtectionTools.Core.Elements.Groups {
    #region References

    using System.Collections.Generic;
    using Connections.Factory;
    using ElectroReceivers;
    using Lines;

    #endregion

    public class ElementGroup : AbstractChainElement, IElementGroup {
        public ElementGroup(IConnectionFactory connectionFactory) : base(connectionFactory) {
            Elements = new List<IElectroReceiver>();
        }

        public ICollection<IElectroReceiver> Elements { get; }
    }
}