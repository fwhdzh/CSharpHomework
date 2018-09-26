using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1024];
            Console.Write("Please input the length of the array:");
            String s = Console.ReadLine();
            int n = int.Parse(s);
            Console.WriteLine("Please input the elements of the array(Two elements are separated by a space):");
            string[] str = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) { a[i] = int.Parse(str[i]); }
            int Maximum = -2147483648;
            int Minimum = 2147483647;
            int sum = 0 ;
            float average = 0.0f;
            for (int i=0;i<n;i++)
            {
                if (a[i] > Maximum) { Maximum = a[i]; }
                if (a[i] < Minimum) { Minimum = a[i]; }
                sum += a[i];
            }
            average = (float)sum / n;
            Console.WriteLine("Maximum = " + Maximum);
            Console.WriteLine("Minimum = " + Minimum);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
            Console.ReadLine();
        }
    }
}
