using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public class PlutoObject
    {
        private Planet _planet = null;
        protected Position _position;

        public PlutoObject(Position initialPosition)
        {
            _position = new Position(initialPosition);
        }

        public void SetPlanet(Planet planet)
        {
            _planet = planet;
        }

        public Position GetPosition()
        {
            return new Position(_position);
        }
    }
}
