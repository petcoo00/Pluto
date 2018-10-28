using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLib;

namespace Pluto.Tests
{
    [TestClass]
    public class OffGridTests
    {

        [TestMethod]
        public void ReceiveCommand_MoveOffGrid_North()
        {
            Planet planet = new Planet(10, 10);
            PlutoRover rover = new PlutoRover(new Position(3, 9, Orientation.N));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(3, 0, Orientation.N));
        }

        [TestMethod]
        public void ReceiveCommand_MoveOffGrid_East()
        {
            Planet planet = new Planet(10, 10);
            PlutoRover rover = new PlutoRover(new Position(9, 3, Orientation.E));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(0, 3, Orientation.E));
        }

        [TestMethod]
        public void ReceiveCommand_MoveOffGrid_South()
        {
            Planet planet = new Planet(10, 10);
            PlutoRover rover = new PlutoRover(new Position(3, 0, Orientation.S));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(3, 9, Orientation.S));
        }

        [TestMethod]
        public void ReceiveCommand_MoveOffGrid_West()
        {
            Planet planet = new Planet(10, 10);
            PlutoRover rover = new PlutoRover(new Position(0, 3, Orientation.W));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(9, 3, Orientation.W));
        }
    }

}
