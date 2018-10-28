using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public class Utils
    {
        private static int OrientationLength = Enum.GetNames(typeof(Orientation)).Length;

        public static Orientation IncrementOrientation(Orientation o)
        {
            int i = (int)o + 1;
            if (i == OrientationLength) i = 0;
            return (Orientation)i;
        }

        public static Orientation DecrementOrientation(Orientation o)
        {
            int i = (int)o - 1;
            if (i == -1) i = OrientationLength - 1;
            return (Orientation)i;
        }
    }
}
