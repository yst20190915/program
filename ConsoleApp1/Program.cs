using System;
using Introduction= Wrox.ProCSharp.Basics;

class Test
{
    public static int Main()
    {
        Introduction::NamespaceExample NSEx = new Introduction::NamespaceExample();//名称空间别名修饰符为：：
        Console.WriteLine(NSEx.GetNamespace());
        return 0;
    }
}

namespace Wrox.ProCSharp.Basics
{
   class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;//用以访问表示类的类型的TYpe对象
        }
    }
}

