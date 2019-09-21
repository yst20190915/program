using System;

namespace week
{
    class Program
    {
      
        static void Main(string [] ags)
        {
            int s = 0, num = 80;
            while(s<num)
            {
                s++;
                if(s>40)
                {
                    break;
                }
                if ((s%2)==0)
                {
                    continue;
                }
                Console.WriteLine(s);
            }

        }
    }
}
