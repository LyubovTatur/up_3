using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    class Triangle
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public double p1top2;
        public double p2top3;
        public double p3top1;

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.p1top2 = Distance(this.point1, this.point2);
            this.p2top3 = Distance(this.point2, this.point3);
            this.p3top1 = Distance(this.point3, this.point1);
        }

        public double Square()
        {
            return Math.Sqrt(p() * (p() - p1top2) * (p() - p2top3) * (p() - p3top1));
        }
        public double P()
        {
            return p1top2 + p2top3 + p3top1;
        }
        public double p()
        {
            return P() / 2.0;
        }
        private double Distance(Point p1, Point p2)
        {
            Point pointBetween = new Point(p1.x, p2.y);
            double legX = Math.Abs(p1.y - pointBetween.y);
            double legY = Math.Abs(p2.x - pointBetween.x);
            return Math.Sqrt(legX * legX + legY * legY);
        }

    }

}
