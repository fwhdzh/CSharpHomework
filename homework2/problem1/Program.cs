using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number, this program will give you all the prime factors of the number.");
            String s = Console.ReadLine();
            int n = int.Parse(s);
            int i = 2;
            Console.Write("" + n + " = ");
            while (n >= i)
            {
                if ((n % i) == 0)
                {
                    if (n == i) { Console.Write(i); }
                    else { Console.Write("" + i + "*"); }
                    n = n / i;
                }
                else { i++; }
            }
            Console.ReadLine();
        }
    }
}
