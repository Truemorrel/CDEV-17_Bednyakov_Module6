using System;

namespace Task_6_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight tl = new TrafficLight();
            tl.GetLight();
            tl.ChangeColor();
            tl.GetLight();
            tl.ChangeColor();
            tl.GetLight();
            tl.ChangeColor();
            tl.GetLight();
            tl.ChangeColor();
            tl.GetLight();
        }
        class TrafficLight
        {
            private Color _lightColor;
            public TrafficLight()
            {
                _lightColor = Color.red;
            }
            public Color GetLight()
            {
                return _lightColor;
            }
            public void ChangeColor()
            {
                _lightColor++;
            }
        }
        enum Color:byte
        {
            red = 1,
            yellow,
            green
        }
    }
}
