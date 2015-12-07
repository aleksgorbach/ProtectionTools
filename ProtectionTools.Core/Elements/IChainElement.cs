// Created 07.12.2015
// Modified by  07.12.2015 at 14:52

namespace ProtectionTools.Core.Elements {
    #region References

    using System.Collections.Generic;
    using Connections;
    using Lines;

    #endregion

    internal interface IChainElement : IConnectable {
        IEnumerable<IConnection> Connections { get; }
    }
}