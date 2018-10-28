using System;
using System.Collections.Generic;

namespace PlutoLib
{
    public class PlutoRover: PlutoObject
    {
        public PlutoRover(Position initialPosition) : base(initialPosition)
        {
        }

        public MovementReport ProcessCommands(List<PlutoCommand> commands)
        {

            return null;
        }

        public MovementReport ProcessCommand(PlutoCommand command)
        {
            Position proposed = this.GetPosition().HandleCommand(command);
            proposed = _planet.Wrap(proposed);
            List<PlutoObject> obstructions = _planet.ObjectsAt(proposed);

            if (obstructions is null || 0 == obstructions.Count ||
                (1 == obstructions.Count && object.ReferenceEquals(obstructions[0], this)))
            {
                this._position = proposed;
                return new MovementReport(true, null);
            }
            else
            {
                return new MovementReport(false, obstructions);
            }
        }
    }
}
