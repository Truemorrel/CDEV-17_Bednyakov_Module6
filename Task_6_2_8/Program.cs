using System;

namespace Task_6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Employee();

        }
    }
    public class Rectangle
    {
        public int a;
        public int b;
        public int Square()
        {
            return a * b;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int aside, int bside)
        {
            a = aside;
            b = bside;
        }
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }
    }
}
