using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLib;

namespace Pluto.Tests
{
    [TestClass]
    public class ObstacleTests
    {
        [TestMethod]
        public void ReceiveCommand_Obstacle_FaceNorth()
        {
            Planet planet = new Planet();
            Rock rock = new Rock(new Position(4, 5, Orientation.N));
            planet.AddObject(rock);
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.N));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.N));
        }

        [TestMethod]
        public void ReceiveCommand_Obstacle_FaceEast()
        {
            Planet planet = new Planet();
            Rock rock = new Rock(new Position(5, 4, Orientation.N));
            planet.AddObject(rock);
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.E));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.IsTrue(rover.GetPosition() == (new Position(4, 4, Orientation.E)));
        }

        [TestMethod]
        public void ReceiveCommand_Obstacle_FaceSouth()
        {
            Planet planet = new Planet();
            Rock rock = new Rock(new Position(4, 3, Orientation.N));
            planet.AddObject(rock);
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.S));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.S));
        }

        [TestMethod]
        public void ReceiveCommand_Obstacle_FaceWest()
        {
            Planet planet = new Planet();
            Rock rock = new Rock(new Position(3, 4, Orientation.N));
            planet.AddObject(rock);
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.W));
            planet.AddObject(rover);
            rover.ProcessCommand(PlutoCommand.F);
            Assert.AreEqual(rover.GetPosition(), new Position(4, 4, Orientation.W));
        }


        [TestMethod]
        public void ReceiveCommand_MultipleCommandsAndObstruction()
        {
            Planet planet = new Planet();
            Rock rock = new Rock(new Position(6, 6, Orientation.N));
            planet.AddObject(rock);
            PlutoRover rover = new PlutoRover(new Position(4, 4, Orientation.N));
            planet.AddObject(rover);
            var commands = new List<PlutoCommand>() {
                PlutoCommand.F,
                PlutoCommand.F,
                PlutoCommand.R,
                PlutoCommand.F,
                PlutoCommand.F };
            MovementReport report = rover.ProcessCommands(commands);
            Assert.AreEqual(rover.GetPosition(), new Position(5, 6, Orientation.E));
            Assert.IsFalse(report.Success);
            Assert.IsTrue(object.ReferenceEquals(rock, report.Obstructions[0]));
        }
    }
}
