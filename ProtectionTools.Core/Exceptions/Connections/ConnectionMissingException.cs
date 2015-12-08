// Created 08.12.2015
// Modified by  08.12.2015 at 14:07

namespace ProtectionTools.Core.Exceptions.Connections {
    #region References

    using System;
    using Lines;

    #endregion

    internal class ConnectionMissingException : InvalidOperationException {
        public ConnectionMissingException(IConnectable source, IConnectable element) {
            Element = source;
            Connecting = element;
        }

        public IConnectable Element { get; }
        public IConnectable Connecting { get; }
    }
}