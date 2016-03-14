// Created 07.12.2015
// Modified by  07.12.2015 at 15:02

namespace ProtectionTools.Core.Elements.Connections {
    #region References

    using System;
    using Lines;

    #endregion

    /// <summary>
    /// Line connection to element
    /// </summary>
    public interface IConnection {
        IConnectable Element { get; }
        ILine Line { get; }
    }
}