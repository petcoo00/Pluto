using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLib;

namespace Pluto.Tests
{
    [TestClass]
    public class TurningTests
    {
        [TestMethod]
        public void ReceiveCommand_Turning()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.N));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.L);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.W));
            rover.ProcessCommand(PlutoCommand.L);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.S));
            rover.ProcessCommand(PlutoCommand.L);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.E));
            rover.ProcessCommand(PlutoCommand.L);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.N));
            rover.ProcessCommand(PlutoCommand.R);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.E));
            rover.ProcessCommand(PlutoCommand.R);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.S));
            rover.ProcessCommand(PlutoCommand.R);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.W));
            rover.ProcessCommand(PlutoCommand.R);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.N));
        }
    }

}
