// Created 08.12.2015
// Modified by  08.12.2015 at 14:40

namespace ProtectionTools.Core.Tests.Elements {
    #region References

    using Buses;
    using Core.Elements.Connections.Factory;
    using Exceptions.Connections;
    using Lines;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    #endregion

    [TestClass]
    public class AbstractChainElementTests {
        [TestMethod]
        public void Add_Element_CountIncreased() {
            // arrange
            var connectionFactory = Mock.Of<IConnectionFactory>();
            var bus = new SimpleBus(connectionFactory, 1);
            var inputConnection = Mock.Of<IConnectable>();


            // act
            var connection = bus.ConnectInput(inputConnection);

            // assert
            Assert.AreEqual(bus.InConnections.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof (ConnectionMissingException))]
        public void Remove_Element_ExceptionOnEmptyInputs() {
            // arrange
            var connectionFactory = Mock.Of<IConnectionFactory>();
            var element = new SimpleBus(connectionFactory, 1);
            var inputConnection = Mock.Of<IConnectable>();


            // act
            element.DisconnectInput(inputConnection);

            // assert
        }
    }
}