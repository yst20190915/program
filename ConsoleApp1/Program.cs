using System;
using System.Collections;

namespace Wrox.ProCSharp
{
       public  class A
    {
          public static void Main()
       {
         var list = new ArrayList();
        list.Add(44);
        int i1 = (int)list[0];
        foreach (int i2 in list )
        {
            Console.WriteLine(i2);
        }
    }
    }

   
  
}


