// Created 08.12.2015
// Modified by Александр 08.12.2015 at 21:12

namespace ProtectionTools.Core.Elements.Groups {
    #region References

    using System.Collections.Generic;
    using ElectroReceivers;

    #endregion

    internal interface IElementGroup {
        ICollection<IElectroReceiver> Elements { get; }
    }
}