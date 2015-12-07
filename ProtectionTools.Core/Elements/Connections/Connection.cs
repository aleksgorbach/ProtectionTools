// Created 07.12.2015
// Modified by  07.12.2015 at 14:44

namespace ProtectionTools.Core.Elements.Connections {
    #region References

    using Lines;

    #endregion

    internal class Connection : IConnection {
        public Connection(IConnectable element, ILine line) {
            Element = element;
            Line = line;
        }

        public IConnectable Element { get; }
        public ILine Line { get; }
    }
}