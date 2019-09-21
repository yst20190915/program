using System;
using System.Collections;

namespace week
{
    class Program
    {    
        static void Main(string [] ags)
        {
            ArrayList alt = new ArrayList();
            alt.Add("用一生下载你");
            alt.Add("一生所爱");
            alt.Add("痞子");
            Console.WriteLine("您收藏的网名有:");
            foreach(string InternetName in alt)
            {
                Console.WriteLine(InternetName);
            }
            
        }
    }
}
