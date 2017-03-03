using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        Point pointA;
        Point pointB;
        Point pointC;

        double e1;
        double e2;
        double e3;

        public Triangle(Point pointA, Point pointB, Point pointC)
        {          
            
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;


            e1 = new Edge(pointA, pointB).FindLenghtSegments;
            e2 = new Edge(pointA, pointC).FindLenghtSegments;
            e3 = new Edge(pointB, pointC).FindLenghtSegments;

        }
        public double Perimetr
        {
            get
            {
                double perimetr = e1 + e2 + e3;
                return perimetr;
            }
        }
        public double Area
        {
            get
            {
                double p_half = Perimetr / 2;
                return Math.Sqrt(p_half * (p_half - e1) * (p_half - e2) * (p_half - e3));
            }

        }
        public bool Right()
        {
            bool flag = false;

            if (Math.Sqrt(Math.Pow(e1, 2) + Math.Pow(e2, 2)) == Math.Pow(e3, 2))
                flag = true;
            if (Math.Sqrt(Math.Pow(e2, 2) + Math.Pow(e3, 2)) == Math.Pow(e1, 2))
                flag = true;
            if (Math.Sqrt(Math.Pow(e1, 2) + Math.Pow(e3, 2)) == Math.Pow(e2, 2))
                flag = true;

            return flag;
        }

        public bool Isosceles()
        {
            if (e1 == e2 || e2 == e3 || e3 == e1)
                return true;
            else
                return false;
        }
         
        //Проверка, не совпадают ли точки в треугольнике
        public bool CoincidePoints(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    if (points[i].GetCoordinateX() == points[i + 1].GetCoordinateX() && points[i].GetCoordinateY() == points[i + 1].GetCoordinateY())
                    {
                        return true;
                    }
                }
                else
                {
                    if (points[i].GetCoordinateX() == points[0].GetCoordinateX() && points[i].GetCoordinateY() == points[0].GetCoordinateY())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Проверка, лежат ли точки на одной прямой/нет
        public bool Points()
        {
            if ((pointC.GetCoordinateX() == pointA.GetCoordinateX()) && (pointC.GetCoordinateX() == pointB.GetCoordinateX()) ||
                (pointC.GetCoordinateY() == pointA.GetCoordinateY()) && (pointC.GetCoordinateY() == pointB.GetCoordinateY()))
                return true;

            return false;
        }

    }

}
