using System;
using System.Collections;

namespace week
{
    class Program
    {    
        static void Main(string [] ags)
        {
            Console.WriteLine("请输入要查找的文字:");
            string inputstr = Console.ReadLine();
            string[] mystr = new string[3];
            mystr[0] = "你";
            mystr[1] = "好";
            mystr[2] = "呀";
            for(int i=0;i<mystr.Length;i++)
            {
                if (mystr [i].Equals(inputstr))
                {
                    goto Found;
                }
                 
            }
            Console.WriteLine("您查找的{0}不存在", inputstr);
            goto Finish;
        Found:
            Console.WriteLine("您查找的{0}存在", inputstr);
        Finish:
            Console.WriteLine("查找完毕");
        }
    }
}
