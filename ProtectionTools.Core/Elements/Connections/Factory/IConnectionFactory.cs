// Created 07.12.2015
// Modified by  07.12.2015 at 14:58

namespace ProtectionTools.Core.Elements.Connections.Factory {
    #region References

    using Lines;

    #endregion

    public interface IConnectionFactory {
        IConnection Create(IConnectable element);
    }
}