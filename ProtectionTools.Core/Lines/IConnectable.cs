// Created 07.12.2015
// Modified by  07.12.2015 at 14:59

namespace ProtectionTools.Core.Lines {
    internal interface IConnectable {
        /// <summary>
        /// Connects the element with other
        /// </summary>
        /// <param name="element">Element to connect with</param>
        /// <returns>Connecting line</returns>
        ILine Connect(IConnectable element);
    }
}