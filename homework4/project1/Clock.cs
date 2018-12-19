using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project1
{
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);

    class Clock
    {
        public event ClockEventHandler Alerm;
        public void setAlerm()
        {
            Console.WriteLine("请输入闹钟时间，格式为18:00:00");
            string s = "";
            s = Console.ReadLine();
            DateTime expTime = DateTime.Parse(s);
            TimeSpan a = new TimeSpan(0,0,1);
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if ((expTime-DateTime.Now)<a)
                {
                    Console.WriteLine(DateTime.Now - expTime);
                    ClockEventArgs args = new ClockEventArgs();
                    args.nowTime = expTime;
                    Alerm(this, args);
                    break;
                }
            }
        }
    }
}
