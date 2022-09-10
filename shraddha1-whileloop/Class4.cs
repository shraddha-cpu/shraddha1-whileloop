using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha1_whileloop
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a=(int)Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=6)
            {
                Console.WriteLine(a+ "*" +i+"="+ i*a);
                Console.WriteLine(a+ "/" +i+"="+ i/a);
                Console.WriteLine(a+ "%" +i+"="+ i%a);

                i++;
            }
            Console.ReadLine();
            }
        }
    }

