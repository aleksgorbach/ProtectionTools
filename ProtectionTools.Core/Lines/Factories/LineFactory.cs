// Created 07.12.2015
// Modified by  07.12.2015 at 15:04

namespace ProtectionTools.Core.Lines.Factories {
    #region References

    using Implementations;

    #endregion

    public class LineFactory : ILineFactory {
        public ILine Create() {
            return new SimpleLine();
        }
    }
}