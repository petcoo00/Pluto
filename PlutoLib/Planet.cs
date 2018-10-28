using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public class Planet
    {
        private int _maxX;
        private int _maxY;
        private List<PlutoObject> _objects = new List<PlutoObject>();

        public Planet(int maxX = 10, int maxY = 10)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public List<PlutoObject> ObjectsAt(Position p)
        {
            List<PlutoObject> objs = new List<PlutoObject>();

            foreach (var obj in _objects)
            {

                if (obj.GetPosition().CoordsMatch(p))
                {
                    objs.Add(obj);
                }
            }

            return objs;
        }

        public void AddObject(PlutoObject obj)
        {
            if (!_objects.Contains(obj))
            {
                obj.SetPlanet(this);
                _objects.Add(obj);
            }
        }

        public Position Wrap(Position p)
        {
            if (p.X >= 0 && p.Y >= 0 && p.X < _maxX && p.Y < _maxY)
            {
                return p;
            }
            else
            {
                int correctX = p.X;
                int correctY = p.Y;

                if (p.X < 0)
                {
                    correctX = _maxX + p.X;
                }
                else if (p.X >= _maxX)
                {
                    correctX = p.X - _maxX;
                }

                if (p.Y < 0)
                {
                    correctY = _maxY + p.Y;
                }
                else if (p.Y >= _maxY)
                {
                    correctY = p.Y - _maxY;
                }

                return new Position(correctX, correctY, p.O);
            }
        }
    }
}
