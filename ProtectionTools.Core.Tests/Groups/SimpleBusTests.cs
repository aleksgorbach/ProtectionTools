namespace ProtectionTools.Core.Tests.Groups {
    #region References

    using Buses;
    using Core.Elements.Connections.Factory;
    using Core.Elements.ElectroReceivers;
    using Lines.Factories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    #endregion

    [TestClass]
    public class SimpleBusTests {
        [TestMethod]
        public void Amperage_Equals_81() {
            // Arrange
            var connectionFactory = new ConnectionFactory(Mock.Of<ILineFactory>());
            var bus = new SimpleBus(connectionFactory, 10, 1.18904, 0.38);
            var elem1 = new ElectroReceiver(connectionFactory, 9.3, 1, 0.6, 0.8);
            var elem2 = new ElectroReceiver(connectionFactory, 12, 1, 0.6, 0.8);
            var elem3 = new ElectroReceiver(connectionFactory, 27.4, 1, 0.6, 0.8);
            var elem4 = new ElectroReceiver(connectionFactory, 13, 1, 0.6, 0.8);
            bus.ConnectOutput(elem1);
            bus.ConnectOutput(elem2);
            bus.ConnectOutput(elem3);
            bus.ConnectOutput(elem4);

            // Act
            var amperage = bus.Amperage;

            // Assert

            Assert.AreEqual(amperage, 81, 0.5);
        }
    }
}