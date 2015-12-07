// Created 07.12.2015
// Modified by Александр 07.12.2015 at 20:36

namespace ProtectionTools.Core.Elements {
    #region References

    using System.Collections.Generic;
    using Connections;
    using Lines;

    #endregion

    public interface IChainElement : IConnectable {
        IEnumerable<IConnection> Connections { get; }
    }
}