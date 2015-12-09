// Created 07.12.2015
// Modified by  09.12.2015 at 15:41

namespace ProtectionTools.Core.Lines.Factories {
    public interface ILineFactory {
        /// <summary>
        /// Creates the line
        /// </summary>
        /// <returns>Created line</returns>
        ILine Create();
    }
}