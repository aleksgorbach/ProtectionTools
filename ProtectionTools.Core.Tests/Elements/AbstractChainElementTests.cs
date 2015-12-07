// Created 07.12.2015
// Modified by Александр 07.12.2015 at 21:03

namespace ProtectionTools.Core.Tests.Elements {
    #region References

    using Core.Elements;
    using Core.Elements.Connections;
    using Core.Elements.Connections.Factory;
    using Lines;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    #endregion

    [TestClass]
    public class AbstractChainElementTests {
        [TestMethod]
        public void ElementsConnectedWithSameLine() {
            var connectionFactory = new Mock<IConnectionFactory>();
            connectionFactory.Setup(x => x.Create(It.IsAny<IConnectable>())).Returns(Mock.Of<IConnection>());
            var elem = new Mock<AbstractChainElement>(connectionFactory.Object);
            var elem2 = new Mock<AbstractChainElement>(connectionFactory.Object);
            var line = elem.Object.Connect(elem2.Object);
            var lineBack = elem2.Object.Connect(elem.Object);
            Assert.AreEqual(line, lineBack);
        }
    }
}