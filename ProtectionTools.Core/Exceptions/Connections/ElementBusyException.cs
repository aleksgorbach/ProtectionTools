// Created 08.12.2015
// Modified by  08.12.2015 at 14:03

namespace ProtectionTools.Core.Exceptions.Connections {
    #region References

    using System;
    using Lines;

    #endregion

    public abstract class ElementBusyException : InvalidOperationException {
        protected ElementBusyException(IConnectable source, IConnectable attachable) : base("Element slots are busy") {
            Element = source;
            ConnectingElement = attachable;
        }

        public IConnectable Element { get; }
        public IConnectable ConnectingElement { get; }
    }
}