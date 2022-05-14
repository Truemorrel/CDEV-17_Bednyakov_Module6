using System;

namespace Task_6_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(5, 3, 5.8309518948453);
            ;
            Console.WriteLine("Площадь = {0}",tr.Squar());
         }
        class Triangle
        {
            public double[] sideLength;
            public double Squar()
            {
                double halfPerim = Perimetr() / 2;
                double result = halfPerim;
                for (int i = 0; i < sideLength.Length; i++)
                {
                    result *= halfPerim - sideLength[i];
                }
                return Math.Sqrt(result);
            }
            public double Perimetr()
            {
                double result = 0;
                for(int i = 0; i < sideLength.Length; i++)
                {
                    result = sideLength[i];
                };
                return result;
            }
            public Triangle(params double[] sides)
            {
                sideLength = sides;
            }
        }
        class Rectangle
        {
            public double sideA;
            public double sideB;
            public double Squar()
            {
                return sideA * sideB;
            }

            public double Perimetr()
            {
                return 2 * (sideA + sideB);
            }
            public Rectangle(double side1, double side2)
            {
                sideA = side1;
                sideB = side2;
            }
        }
        class Circle
        {
            public double radius;
            public double Squar()
            {
                return 2 * Math.PI * radius * radius;
            }
            public double Perimetr()
            {
                return 2 * Math.PI * radius;
            }
            public Circle(double r)
            {
                radius = r;
            }
        }
    }
}
