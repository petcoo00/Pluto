using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public class MovementReport
    {
        public bool Success { get; private set; }
        public List<PlutoObject> Obstructions { get; private set; }

        public MovementReport(bool success, List<PlutoObject> obstructions)
        {
            Success = success;
            Obstructions = obstructions;
        }
    }
}
