// Created 07.12.2015
// Modified by  08.12.2015 at 14:12

namespace ProtectionTools.Core.Elements.Protectors {
    #region References

    using Connections.Factory;

    #endregion

    public class Preventer : AbstractChainElement {
        public Preventer(IConnectionFactory connectionFactory) : base(connectionFactory) {
        }
    }
}