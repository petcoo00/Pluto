using System;

namespace PlutoLib
{
    public class PlutoRover: PlutoObject
    {
        private Planet _planet;
        private Position _position;

        public PlutoRover(Planet planet, Position initialPosition)
        {
            _planet = planet;
            _position = new Position(initialPosition);
        }

        public void ProcessCommand(PlutoCommand command)
        {

        }

        public Position GetPosition()
        {
            return new Position(_position);
        }
    }
}
