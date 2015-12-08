// Created 08.12.2015
// Modified by  08.12.2015 at 14:03

namespace ProtectionTools.Core.Exceptions.Connections {
    #region References

    using Lines;

    #endregion

    internal class ElementOutputBusyException : ElementBusyException {
        public ElementOutputBusyException(IConnectable source, IConnectable attachable) : base(source, attachable) {
        }
    }
}