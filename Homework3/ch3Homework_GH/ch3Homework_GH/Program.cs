using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3Homework_GH
{
    interface Sharp
    {
        bool isValue();
        void calculateArea();
        double getArea();
    }

    class Triangle : Sharp
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        double area;
        public Triangle(int x, int y, int z)
        {
            this.a = x; this.b = y; this.c = z;
        }
        public bool isValue()
        {
            return a < b + c && b < a + c && c < a + b && a > 0 && b > 0 && c > 0;
        }
        public void calculateArea()
        {
            int p = a + b + c;
            this.area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double getArea()
        {
            return this.area;
        }
    }

    class Square : Sharp
    {
        public int sideLength { set; get; }
        double area;
        public Square(int length)
        {
            this.sideLength = length;
        }
        public bool isValue()
        {
            return sideLength > 0;
        }
        public void calculateArea()
        {
            area = sideLength * sideLength;
        }
        public double getArea()
        {
            return area;
        }
    }

    class Rectangle : Sharp
    {
        public int height { set; get; }
        public int width { set; get; }
        double area;
        public Rectangle(int a, int b)
        {
            height = a;
            width = b;
        }
        public void calculateArea()
        {
            area = height * width;
        }
        public bool isValue()
        {
            return height > 0 && width > 0;
        }
        public double getArea()
        {
            return area;
        }

    }

    class CreateSharpFactory
    {
        public static Triangle createTriangle()
        {
            Triangle triangle = null;
            Random random = new Random();
            int a = random.Next() % 100;
            int b = random.Next() % 100;
            int c = random.Next() % 100;
            triangle = new Triangle(a, b, c);
            return triangle;
        }

        public static Square createSquare()
        {
            Square square = null;
            Random random = new Random();
            int side = random.Next() % 100;
            square = new Square(side);
            return square;
        }

        public static Rectangle createRectangle()
        {
            Rectangle rectangle = null;
            Random random = new Random();
            int height = random.Next() % 100;
            int width = random.Next() % 100;
            rectangle = new Rectangle(height, width);
            return rectangle;
        }

        public static void randomCreateSharp()
        {
            Random random = new Random();
            int num;
            double AreaSum = 0;
            for(int i = 0; i < 10; i++)
            {
                num = random.Next() % 3;
                switch (num)
                {
                    case 0:
                        Triangle triangle = createTriangle();
                        if (triangle.isValue())
                        {
                            triangle.calculateArea();
                            Console.WriteLine("{0}:创建了一个三角形，面积为{1}",i+1, triangle.getArea());
                            AreaSum += triangle.getArea();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 1:
                        Square square = createSquare();
                        if (square.isValue())
                        {
                            square.calculateArea();
                            Console.WriteLine("{0}:创建了一个正方形，面积为{1}", i + 1, square.getArea());
                            AreaSum += square.getArea();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 2:
                        Rectangle rectangle = createRectangle();
                        if (rectangle.isValue())
                        {
                            rectangle.calculateArea();
                            Console.WriteLine("{0}:创建了一个矩形，面积为{1}", i + 1, rectangle.getArea());
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("这十个图形的面积之和为：{0}", AreaSum);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            if (triangle.isValue())
            {
                triangle.calculateArea();
                Console.WriteLine("该三角形的面积为{0}",triangle.getArea());
            }
            else
            {
                Console.WriteLine("该三角形的不合法");
            }
            Square square = new Square(5);
            if (square.isValue())
            {
                square.calculateArea();
                Console.WriteLine("该正方形的面积为{0}", square.getArea());
            }
            else
            {
                Console.WriteLine("该正方形的不合法");
            }
            Rectangle rectangle = new Rectangle(5, -4);
            if (rectangle.isValue())
            {
                rectangle.calculateArea();
                Console.WriteLine("该矩形的面积为{0}", rectangle.getArea());
            }
            else
            {
                Console.WriteLine("该矩形的不合法");
            }
            Console.WriteLine();

            CreateSharpFactory.randomCreateSharp();

            Console.Read();
        }
    }
}
