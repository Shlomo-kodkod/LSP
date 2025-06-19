using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal interface ICanFly
    {
        public void Fly();
    }

    internal class Bird
    {

    }
    internal class FlyBird : Bird, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly.");
        }
    }

    internal class Penguin : Bird
    {

    }

    internal static class Test1
    {
        public static void MakeBirdFly(ICanFly flyBird)
        {
            flyBird.Fly();
        }
    }

}
