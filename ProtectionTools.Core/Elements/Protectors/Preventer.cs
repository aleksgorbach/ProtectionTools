﻿// Created 07.12.2015
// Modified by  07.12.2015 at 15:04

namespace ProtectionTools.Core.Elements.Protectors {
    #region References

    using Connections.Factory;

    #endregion

    internal class Preventer : AbstractChainElement {
        public Preventer(IConnectionFactory connectionFactory) : base(connectionFactory) {
        }
    }
}