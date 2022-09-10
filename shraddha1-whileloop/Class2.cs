using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha1_whileloop
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int i = 100;
            while (i>=50)
            {
                if (i%2!=0)
                    Console.WriteLine(i);
                i--;
            }
        }
    }
}
