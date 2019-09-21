using System;
using System.Collections;

namespace week
{
    class Program
    {    
        static void Main(string [] ags)
        {
            for (int j=0;j<20;j++)
            {
                if ((j % 2) == 0)
                    continue;
                Console.WriteLine(j);
            }
            
        }
    }
}
