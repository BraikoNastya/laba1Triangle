using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        public static void RandomCoordinate(Point[] points)
        {
            Random gen = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(gen.Next(1, 15), gen.Next(1, 15));
                
                Console.WriteLine("ваша точка x={0} и y={1}", points[i].GetCoordinateX(), points[i].GetCoordinateY());
            }
        }       
        
        static void Main(string[] args)
        {
            double averagePerimeter = 0;
            double averageArea = 0;

            int countRight = 0;
            int countIsosceles = 0;

            Point[] points = new Point[3];
            RandomCoordinate(points);

            Edge[] edges = new Edge[3];

            edges[0] = new Edge(points[0], points[1]);//создание ребра 
            edges[1] = new Edge(points[0], points[2]);
            edges[2] = new Edge(points[1], points[2]);

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Длина ребра = " + edges[i].FindLenghtSegments);

            Triangle[] array = new Triangle[10];
            for (int i = 0; i < 10; i++)
            {
                RandomCoordinate(points);// генерируем новые точки для каждого треугольника
                array[i] = new Triangle(points[0], points[1], points[2]);
                
                if (array[i].Points()==true)
                {
                    Console.WriteLine("треугольник не существует");
                                  
                }                
           }
            for (int i = 0; i < 10; i++)
            {
                if (array[i].Right() == true)
                {
                    Console.WriteLine("Прямоугольный");
                    countRight++;
                    Console.WriteLine("Периметер " + array[i].Perimetr);
                    averagePerimeter += array[i].Perimetr;
                }
                else
                {
                    Console.WriteLine("Не прямоугольный");
                }

                if (array[i].Isosceles() == true)
                {
                    Console.WriteLine("Равнобедренный");
                    countIsosceles++;
                    Console.WriteLine("Площадь " + array[i].Area);
                    averageArea += array[i].Area;
                }
                else
                {
                    Console.WriteLine("Не Равнобедренный");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество прямоуголных треугольников = {0}, их среднее = {1}", countRight, averagePerimeter / countRight);
            Console.WriteLine("Количество равнобедренных треугольников = {0}, их среднее = {1}", countIsosceles, averageArea / countIsosceles);

            Console.WriteLine();
            Console.ReadKey();
        }

    }

}
