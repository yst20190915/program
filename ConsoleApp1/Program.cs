using System;


namespace Worx.ProCSharp
{
    
    public interface IBankAccount//接口
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
       
    }   
}

namespace Worx.ProCSharp .VenusBank
{
    public class SaverAccount:IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >=amount )
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public override string ToString()
        {
            return String.Format("Venus Bank Saver:Balance=(0,6:C)", balance);
        }
        public static void Main()
        {
            string account = Console.ReadLine();
            
        }
    }
}