using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class MyClass
    {
        public List<Point> Task1(Point[] points, double r)
        {
            List<Point> outPoints = new List<Point>();

            for (int i = 1; i < points.Length; i++)
            {
                Point pointBetween = new Point(points[i].x, points[0].y);
                double legX = Math.Abs(points[i].x - pointBetween.x);
                double legY = Math.Abs(points[i].y - pointBetween.y);
                if (Math.Sqrt(legX*legX+legY*legY) > r)
                {
                    outPoints.Add(points[i]);
                }
            }

            return outPoints;
        }

        static public string Task2(Point[] points)
        {
            

            List<Point> topPoints = new List<Point>();
            List<Point> botPoints = new List<Point>();

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].Where(new Point(1, 1), new Point(0, 0)) == 1)
                {
                    topPoints.Add(points[i]);
                }
                if (points[i].Where(new Point(1, 1), new Point(0, 0)) == -1)
                {
                    botPoints.Add(points[i]);   
                }
            }
            Triangle t1, t2;
            for (int i = 0; i < topPoints.Count; i++)
            {
                for (int j = 0; j < topPoints.Count; j++)
                {
                    for (int k = 0; k < topPoints.Count; k++)
                    {
                        if (k!=i && i!=j && k!=j)
                        {
                            t1 = new Triangle(topPoints[i], topPoints[j], topPoints[k]);

                            for (int q = 0; q < botPoints.Count; q++)
                            {
                                for (int w = 0; w < botPoints.Count; w++)
                                {
                                    for (int e = 0; e < botPoints.Count; e++)
                                    {
                                        if (q != w && w != e && q != e)
                                        {
                                            t2 = new Triangle(botPoints[q], botPoints[w], botPoints[e]);
                                            if (t1.Square() == t2.Square())
                                            {
                                                return $"Найдено.\nпервый треугольник: {t1.point1.ToString()} {t1.point2.ToString()} {t1.point3.ToString()}\nвторой треугольник: {t2.point1.ToString()} {t2.point2.ToString()} {t2.point3.ToString()}";
                                            }
                                        }

                                    }
                                }
                            }


                        }
                        

                    }
                }
            }

            return "не найдено";
        }
    }
}
