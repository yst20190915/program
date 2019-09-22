using System;
using System.Collections;
using System.Drawing;

namespace Worx.ProCSharp.StaticConstructorSample
{
     public  class UserPreferences
    {
        public static readonly Color BackColor;
        static  UserPreferences()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                BackColor = Color.Green;
            else
                BackColor = Color.Red;
        }
       
    }
    class MainENtryPoint
    {
        static void Main(string [] args)
        {
            Console.WriteLine("User-preferences:BackColor is {0} ", UserPreferences.BackColor.ToString());
        }
    }
}
