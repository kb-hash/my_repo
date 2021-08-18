using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    public class Shapes
    {
        public void Area(int side)
        {
            int squarearea = side * side;
            Console.WriteLine("The Area of Square is :{0}", squarearea);
        }
        public void Area(int length, int breadth)
        {

            int rectarea = length * breadth;
            Console.WriteLine("The Area of Rectangle is :{0}" ,rectarea);
        }

        public void Area(double radius)
        {
            double circlearea = 3.14 * radius * radius;
            Console.WriteLine("The Area of Circle is :{0:F3}",  circlearea);
        }
        public void Area(int side1,int side2,int side3)
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            Console.Write("Area of  Triangle is:{0:F3} " , Area);
        }


    }
    class Question6
    {
        static void Main()
        {
            Shapes s = new Shapes();
            s.Area(10);
            s.Area(10, 20);
            s.Area(10.8);
            s.Area(12, 11, 15);
        }
    }
}
