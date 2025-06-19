using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Program
    {
        public static void Main()
        {
            Penguin p = new Penguin();
            Test1.MakeBirdFly(p);
            //ICanFly b = new FlyBird();
            //b.Fly();
        }
    }

    


}
