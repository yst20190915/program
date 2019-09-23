using System;

namespace Worx
{
    struct house
    {
        public double length;
        public double wieth;
    }
    class MainENtryPoint
    {
        static void Main(string [] args)
        {
            house home;
            home.length = 2.2;
            home.wieth = 2.3;
            Console.WriteLine("house'square:{0}", home.wieth * home.length);
        }
    }
}
