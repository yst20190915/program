using System;

namespace Worx
{
    abstract class GenericCustomer//抽象函数
    {
        private string name;
        public  GenericCustomer (string name)
        {
            this.name = name;
        }
       
    }
    class Nevermore60Customer:GenericCustomer //派生类
    {
        public Nevermore60Customer (string name,string referrerName)
            :base (name )
        {
            this.referrerName = referrerName;
        }
        private string referrerName;
        private uint highCostMinutesUsed;
    }

    class A
    {
        static  void Main()
        {
            GenericCustomer customer = new Nevermore60Customer("Jack","Jone");


            
        }
    }
}


