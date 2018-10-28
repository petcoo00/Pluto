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

        public void AddObject(PlutoObject obj)
        {
            if (!_objects.Contains(obj))
            {
                obj.SetPlanet(this);
                _objects.Add(obj);
            }
        }
    }
}
