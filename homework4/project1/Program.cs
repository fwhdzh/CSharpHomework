using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.Alerm += ShowProgress;
            clock.setAlerm();
        }

        static void ShowProgress(object sender,ClockEventArgs s)
        {
            Console.WriteLine("Alerm!! Time is " + s.nowTime + " Now!!!");
        }
    }
}
