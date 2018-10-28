using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLib;

namespace Pluto.Tests
{
    [TestClass]
    public class PlutoTests
    {
        [TestMethod]
        public void ReceiveCommand()
        {
            Planet planet = new Planet();
            PlutoRover rover = new PlutoRover(new Position(0, 0, Orientation.N));
            planet.AddObject(rover);

        }
    }
}
