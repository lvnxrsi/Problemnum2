using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x=1 x<=20; x++)
            { 
                if (x % 2 ==0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
