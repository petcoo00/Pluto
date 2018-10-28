using System;
using System.Collections.Generic;
using System.Text;

namespace PlutoLib
{
    public class Planet
    {
        private int _maxX;
        private int _maxY;
        private List<PlutoObject> _objects;

        public Planet(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public void AddObject(PlutoObject obj)
        {
            if (!_objects.Contains(obj))
            {
                _objects.Add(obj);
            }
        }
    }
}
