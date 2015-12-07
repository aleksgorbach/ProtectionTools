// Created 07.12.2015
// Modified by Александр 07.12.2015 at 20:35

namespace ProtectionTools.Core.Lines {
    public interface IConnectable {
        /// <summary>
        /// Connects the element with other
        /// </summary>
        /// <param name="element">Element to connect with</param>
        /// <returns>Connecting line</returns>
        ILine Connect(IConnectable element);
    }
}