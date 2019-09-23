using System;

namespace Worx
{
    abstract class GenericCustomer//抽象函数
    {
        private string name;
        public GenericCustomer ()
        {
            name = "<no name>";
        }
       
    }
    class Nevermore60Customer:GenericCustomer //派生类
    {
        private int highCostMinutesUsed;
    }

    class A
    {
        static  void Main()
        {
            GenericCustomer customer = new Nevermore60Customer();


            
        }
    }
}


