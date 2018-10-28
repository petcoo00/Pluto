using System;

namespace PlutoLib
{
    public class PlutoRover
    {
        private Planet _planet;
        private Position _position;

        public PlutoRover(Planet planet, Position initialPosition)
        {
            _planet = planet;
            _position = new Position(initialPosition);
        }
    }
}
