// Created 07.12.2015
// Modified by  08.12.2015 at 14:12

namespace ProtectionTools.Core.Lines {
    #region References

    using System.Collections.Generic;
    using Elements.Connections;

    #endregion

    public interface IConnectable {
        ICollection<IConnection> InConnections { get; }
        ICollection<IConnection> OutConnections { get; }

        /// <summary>
        /// Connects the element to this input
        /// </summary>
        /// <param name="element">Connected element</param>
        /// <returns>Created connection</returns>
        IConnection ConnectInput(IConnectable element);

        IConnection ConnectOutput(IConnectable element);
        void DisconnectInput(IConnectable element);
        void DisconnectOutput(IConnectable element);
    }
}