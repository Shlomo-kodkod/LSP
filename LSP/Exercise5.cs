using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //not implemnt LSP

    //internal class Validator
    //{
    //    public virtual void IsValid(string input)
    //    {
    //        if (input.Length > 3)
    //        {
    //            Console.WriteLine("accept");
    //        }
    //    }
    //}

    //internal class StrictValidator : Validator
    //{
    //    public override void IsValid(string input)
    //    {
    //        if (input.Length == 0 )
    //        {
    //            throw new Exception("input is empty.");
    //        }
    //    }
    //}

    //internal static class Test5
    //{
    //    public static void RunValidation(List<Validator> valid, string input)
    //    {
    //        foreach(Validator v in valid)
    //        {
    //            v.IsValid(input);    
    //        }
    //    }
    //}


    //implemnt LSP

    internal interface IValidator
    {
        public void IsValid(string input);
    }


    internal class Validator : IValidator
    {
        public void IsValid(string input)
        {
            if (input.Length > 3)
            {
                Console.WriteLine("accept");
            }
            else
            {
                Console.WriteLine("less then 3");
            }
        }
    }

    internal class StrictValidator : IValidator
    {
        public void IsValid(string input)
        {
            if (input.Length == 0)
            {
                throw new Exception("input is empty.");
            }
            
        }
    }

    internal static class Test5
    {
        public static void RunValidation(List<IValidator> valid, string input)
        {
            foreach (Validator v in valid)
            {
                try
                {
                    v.IsValid(input);
                }
                catch
                {
                    Console.WriteLine("input is empty!");
                }
            }
        }
    }




}
