using System;
using System.Collections;
using System.Collections.Generic;

namespace Wrox.ProCSharp
{
       public  class A
      {
          public static void Main()
          {
            var list = new List<int>();
            list.Add(44);
            var stringlist = new List<string>();
            stringlist.Add("mystring");
            var myClassList = new List<MyClass>();
            myClassList.Add(new MyClass());
            int i1 = (int)list[0];
            foreach (int i in list )
            {
              Console.WriteLine(i);
            }
           }
        public class MyClass
        {
            string name;

        }
       }

   
  
}


