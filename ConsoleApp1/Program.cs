using System;

namespace week
{
    class Program
    {
      
        static void Main(string [] ags)
        {
            bool term = false;
            int[] myArry = new int[5] { 0, 1, 2, 3, 4 };
            do
            {
                for (int i = 0; i < myArry.Length; i++)
                {
                    Console.WriteLine(myArry[i]);
                }
            } while (term);
            
        }
    }
}
