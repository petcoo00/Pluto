using System;

namespace PlutoLib
{
    public class PlutoRover: PlutoObject
    {
        public PlutoRover(Position initialPosition) : base(initialPosition)
        {
        }

        public void ProcessCommand(PlutoCommand command)
        {
            Position proposed = this.GetPosition().HandleCommand(command);
            this._position = proposed;
        }
    }
}
