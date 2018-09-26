using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will give you all the prime numbers between 2 to 100. They are:");
            Boolean[] f = new Boolean[101];
            for (int i = 0; i < 100;i++) { f[i] = true; }
            for (int i = 2; i < 100; i++)
            {
                if (f[i])
                {
                    Console.Write("" + i + " ");
                    int j=i;
                    while (j < 101)
                    {
                        f[j] = false;
                        j += i;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
