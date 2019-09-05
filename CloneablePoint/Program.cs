using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");

            // Construct points.
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            // Change p2(and p1)'s X coordinate to 0.
            p2.X = 0;

            // Change p4.X (this will not change p3.X).
            p4.X = 0;

            // Print each object.
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.ReadLine();
        }
    }
}
