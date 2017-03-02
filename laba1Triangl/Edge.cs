using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        private Point pointA;
        private Point pointB;


        public Edge(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;

        }
        public Point PointA
        {
            get { return pointA; }
        }

        public Point PointB
        {
            get { return pointB; }
        }
        public double FindLenghtSegments
        {
            get
            {
                return Math.Sqrt(Math.Pow(pointB.GetCoordinateX() - pointA.GetCoordinateX(), 2) + Math.Pow(pointB.GetCoordinateY() - pointA.GetCoordinateY(), 2));
            }
        }

    }
}
