using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLib;

namespace Pluto.Tests
{
    [TestClass]
    public class PlutoTests
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

        [TestMethod]
        public void ReceiveCommand_Forward_FaceNorth()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.N));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 5, Orientation.N));
            rover.ProcessCommand(PlutoCommand.B);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.N));
        }

        [TestMethod]
        public void ReceiveCommand_Forward_FaceEast()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.E));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.IsTrue(rover.GetPosition() == (new Position(5, 4, Orientation.E)));
            rover.ProcessCommand(PlutoCommand.B);
            Assert.IsTrue(rover.GetPosition().Equals( new Position(4, 4, Orientation.E)));
        }

        [TestMethod]
        public void ReceiveCommand_Forward_FaceSouth()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.S));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 3, Orientation.S));
            rover.ProcessCommand(PlutoCommand.B);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.S));
        }

        [TestMethod]
        public void ReceiveCommand_Forward_FaceWest()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.W));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(3, 4, Orientation.W));
            rover.ProcessCommand(PlutoCommand.B);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.W));
        }

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
