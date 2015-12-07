// <copyright file="AbstractChainElementTest.cs" company="CtrlSoft">Copyright © CtrlSoft 2015</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProtectionTools.Core.Elements;
using ProtectionTools.Core.Elements.Connections;
using ProtectionTools.Core.Lines;

namespace ProtectionTools.Core.Elements.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для AbstractChainElement</summary>
    [PexClass(typeof(AbstractChainElement))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AbstractChainElementTest
    {
        /// <summary>Тестовая заглушка для Connect(IConnectable)</summary>
        [PexMethod]
        internal ILine ConnectTest(
            [PexAssumeNotNull]AbstractChainElement target,
            IConnectable element
        )
        {
            ILine result = target.Connect(element);
            return result;
            // TODO: добавление проверочных утверждений в метод AbstractChainElementTest.ConnectTest(AbstractChainElement, IConnectable)
        }

        /// <summary>Тестовая заглушка для get_Connections()</summary>
        [PexMethod]
        internal IEnumerable<IConnection> ConnectionsGetTest([PexAssumeNotNull]AbstractChainElement target)
        {
            IEnumerable<IConnection> result = target.Connections;
            return result;
            // TODO: добавление проверочных утверждений в метод AbstractChainElementTest.ConnectionsGetTest(AbstractChainElement)
        }
    }
}
