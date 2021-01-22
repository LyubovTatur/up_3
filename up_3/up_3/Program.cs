using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDll;

namespace up_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0,2);
            Point p2 = new Point(1,2);
            Point p3 = new Point(1,3);

            Point p4 = new Point(3,2);
            Point p5 = new Point(3,1);
            Point p6 = new Point(4,2);
            Point[] p = new Point[] {p1,p2,p3,p4,p5,p6 };
            // Console.WriteLine(p1.Where(new Point(1, 1), new Point(0, 0)));
            Console.WriteLine(MyClass.Task2(p));
            Console.ReadLine();

        }
    }
}
