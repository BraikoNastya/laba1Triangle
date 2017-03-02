using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        int coordinateX;
        int coordinateY;

        public Point(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;

        }
        public int GetCoordinateX()
        {
            return coordinateX;
        }

        public int GetCoordinateY()
        {
            return coordinateY;
        }
    }
}
