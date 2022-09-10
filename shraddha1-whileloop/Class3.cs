using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha1_whileloop
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=100)
            {
                if (i%5==0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
