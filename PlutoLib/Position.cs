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

        public static bool operator ==(Position obj1, Position obj2)
        {
            if (obj1 is null)
            {
                return obj2 is null;
            }
            else return obj1.Equals(obj2);
        }

        public static bool operator !=(Position obj1, Position obj2)
        {
            if (obj1 is null)
            {
                return !(obj2 is null);
            }
            else return !obj1.Equals(obj2);
        }

        public override int GetHashCode()
        {
            return (int)O + 10 * X + 1000 * Y;
        }

        public override bool Equals(object obj)
        {
            Position other = obj as Position;

            if (null != other)
            {
                return X == other.X && Y == other.Y && O == other.O;
            }

            return base.Equals(obj);
        }

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

        public Position HandleCommand(PlutoCommand command)
        {
            switch (command)
            {
                case PlutoCommand.L:
                    return new Position(X, Y, Utils.DecrementOrientation(O));
                case PlutoCommand.R:
                    return new Position(X, Y, Utils.IncrementOrientation(O));
                default:
                    {
                        int step = command == PlutoCommand.F ? 1 : -1;

                        switch (O)
                        {
                            case Orientation.N:
                                return new Position(X, Y + step, O);
                            case Orientation.E:
                                return new Position(X + step, Y, O);
                            case Orientation.S:
                                return new Position(X, Y - step, O);
                            case Orientation.W:
                                return new Position(X - step, Y, O);
                            default:
                                return null;
                        }
                    }
            }
        }
    }
}
