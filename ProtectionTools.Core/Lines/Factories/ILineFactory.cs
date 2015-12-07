// Created 07.12.2015
// Modified by  07.12.2015 at 14:56

namespace ProtectionTools.Core.Lines.Factories {
    internal interface ILineFactory {
        /// <summary>
        /// Creates the line
        /// </summary>
        /// <returns>Created line</returns>
        ILine Create();
    }
}