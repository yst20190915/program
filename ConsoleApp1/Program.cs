using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            RederenceAndValue.Demonstration();

        }
    }
    public  class stamp
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static class RederenceAndValue
    {
        public static void Demonstration()
        {
            stamp Stamp_1 = new stamp { Name = "john", Age = 25 };//实例化  
            Console.WriteLine("Name:{0} ,Age:{1} ",Stamp_1.Name,Stamp_1.Age);


        }
    }
}

