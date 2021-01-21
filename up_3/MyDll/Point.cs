using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyDll
{
    public class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public int Where(Point p1, Point p2)
        {
            // if abs((tx - x1) * (y2 - y1) - (x2 - x1) * (ty - y1)) < e
            if ((x - p1.x) * (p2.y - p1.y) - (p2.x - p1.x) * (y - p1.y) > 0)
            {
                return 1;
            }
            if ((x - p1.x) * (p2.y - p1.y) - (p2.x - p1.x) * (y - p1.y) < 0)
            {
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"[{x},{y}]";
        }
    }
}
