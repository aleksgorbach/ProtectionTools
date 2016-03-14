﻿// Created 08.12.2015
// Modified by  09.12.2015 at 15:25

namespace ProtectionTools.Core.Buses {
    #region References

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Elements;
    using Elements.Connections.Factory;
    using Elements.ElectroReceivers;
    using Elements.Groups;

    #endregion

    public class SimpleBus : AbstractChainElement, IElementGroup {
        public double NominalVoltage { get; set; }
        public double PowerCoef { get; set; }

        public SimpleBus(IConnectionFactory connectionFactory, int maxOutputCount, double powerCoef,
            double nominalVoltage)
            : base(connectionFactory) {
            PowerCoef = powerCoef;
            NominalVoltage = nominalVoltage;
            MaxOutputsCount = maxOutputCount;
        }

        public SimpleBus(IConnectionFactory connectionFactory, int maxOutputCount) : base(connectionFactory) {
            MaxOutputsCount = maxOutputCount;
        }

        protected override int MaxOutputsCount { get; }

        private ICollection<IElectroReceiver> Elements {
            get { return OutConnections.Select(connection => connection.Element).OfType<IElectroReceiver>().ToList(); }
        }

        private double Coef {
            get { return OutConnections.Count <= 10 ? 1.1 : 1; }
        }

        public double CountedActivePower {
            get { return PowerCoef*Elements.Sum(element => element.UsingCoefficient*element.TotalNominalPower); }
        }

        public double CountedReactivePower {
            get { return Elements.Sum(element => element.ReactiveLoad)*Coef; }
        }

        public double Amperage {
            get { return TotalCountedPower/(Math.Sqrt(3)*NominalVoltage); }
        }

        public double TotalCountedPower {
            get {
                var active = CountedActivePower;
                var reactive = CountedReactivePower;
                return Math.Sqrt(active*active + reactive*reactive);
            }
        }
    }
}