using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public enum Orientation
    {
        N,
        E,
        S,
        W
    }

    public enum PlutoCommand
    {
        F,
        B,
        L,
        R
    }

    public class Position
    {
        int X { get; set; }
        int Y { get; set; }
        Orientation O { get; set; }

        public Position(Position p)
        {
            X = p.X;
            Y = p.Y;
            O = p.O;
        }

        public Position(int x, int y, Orientation o)
        {
            X = x;
            Y = y;
            O = o;
        }
    }
}
