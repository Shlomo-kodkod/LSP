using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //not implemnt LSP

    //internal class BankAccount
    //{
    //    public virtual int GetAvailableBalance()
    //    {
    //        return 10000;
    //    }
    //}

    //internal class DebtAccount : BankAccount
    //{
    //    public override int GetAvailableBalance()
    //    {
    //        return -10000;
    //    }
    //}

    //internal static class Test4
    //{
    //    public static void SumBalances(List<BankAccount> accounts)
    //    {
    //        int sum = 0;
    //        foreach(BankAccount bank in accounts)
    //        {
    //            sum += bank.GetAvailableBalance();
    //        }

    //        Console.WriteLine(sum);
    //    }

    //}


    //implemnt LSP

    internal interface IAccount
    {
        public int GetBalance();
    }

    internal class BankAccount : IAccount
    {
        public virtual int GetBalance()
        {
            return 10000;
        }
    }

    internal class DebtAccount : IAccount
    {
        public int GetBalance()
        {
            return -10000;
        }
    }

    internal static class Test4
    {
        public static void SumBalances(List<IAccount> accounts)
        {
            int sum = 0;
            foreach (IAccount bank in accounts)
            {
                sum += bank.GetBalance();
            }

            Console.WriteLine(sum);
        }

    }

}
