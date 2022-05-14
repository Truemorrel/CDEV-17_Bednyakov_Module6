using System;

namespace Task_6_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bus bus = new Bus();
            bus.Load = 144;
            bus.PrintStatus();
            Bus bus1 = new Bus();
            bus1.PrintStatus();
        }
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if(Load.HasValue)
                {
                    Console.WriteLine("В автобусе {0} пассажиров",Load);
                }
                else
                {
                    Console.WriteLine("Автобус пустой");
                }    
            }
        }
    }
}
