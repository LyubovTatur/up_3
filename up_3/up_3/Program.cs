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
            Console.WriteLine("Задание 1");
            Point[] points1 = new Point[] { new Point(1, 2), new Point(1, 3), new Point(1, 5), new Point(3, 3), new Point(-1, -1), new Point(-2, -4), };
            var points2 = MyClass.Task1(points1, 1);
            MyClass.ShowPoints(points2);
            Console.WriteLine("Задание 2");            
            Console.WriteLine("Эти должны подходить");
            Point p1 = new Point(0,2);
            Point p2 = new Point(1,2);
            Point p3 = new Point(1,3);

            Point p4 = new Point(3,2);
            Point p5 = new Point(3,1);
            Point p6 = new Point(4,2);
            Point[] p = new Point[] {p1,p2,p3,p4,p5,p6 };
            // Console.WriteLine(p1.Where(new Point(1, 1), new Point(0, 0)));
            Console.WriteLine(MyClass.Task2(p));
            Console.WriteLine("Эти не должны");
            Point po1 = new Point(0, 4);//вот тут что то поменяла
            Point po2 = new Point(1, 2);
            Point po3 = new Point(1, 3);
                   
            Point po4 = new Point(3, 2);
            Point po5 = new Point(3, 1);
            Point po6 = new Point(4, 2);
            Point[] po= new Point[] { po1, po2, po3, po4, po5, po6 };
            Console.WriteLine(MyClass.Task2(po));
            Console.WriteLine("Задание 3");
            Console.WriteLine(6.324 - 6.324 %1.0);
            MyClass.Task3(new Point(1, 1), new Point(6.34, 4.3));
            Console.ReadLine();

        }
    }
}
