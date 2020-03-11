using System;
using System.Threading;

namespace clock
{
    //声明一个委托类型，定义事件处理函数的格式
    public delegate void ClockEventHandler(object sender, TimeEventArgs args);

    public class TimeEventArgs
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
    }

    public class Clock
    {
        //定义时间，相当于创建一个委托实例
        public event ClockEventHandler AlarmEvent;
        public event ClockEventHandler TickEvent;

        public void setTime(TimeEventArgs args)
        {
            args.Hour = DateTime.Now.Hour;
            args.Min = DateTime.Now.Minute;
            args.Sec = DateTime.Now.Second;
        }

        public void Work(int h, int m, int s)
        {
            Console.WriteLine($"Right now is {h}:{m}:{s}. Start from here:");
            TimeEventArgs args = new TimeEventArgs()
            {
                Hour = h,
                Min = m,
                Sec = s
            };
            while (true)
            {
                setTime(args);
                //TickEvent(this, args);
                if (args.Sec %5 == 0)
                {
                    AlarmEvent(this, args);
                }
                else
                {
                    TickEvent(this, args);
                }
                Thread.Sleep(1000);
            }
        }
    }
    public class Test
    {
        public Clock clock = new Clock();
        public Test()
        {
            //为clock的两个事件添加方法
            clock.AlarmEvent += new ClockEventHandler(ClockAlarm);
            clock.TickEvent += new ClockEventHandler(ClockTick);
        }
        void ClockAlarm(object sender,TimeEventArgs args)
        {
            Console.WriteLine($"Now is {args.Hour}:{args.Min}:{args.Sec}");
        }
        void ClockTick(object sender,TimeEventArgs args)
        {
            Console.WriteLine($"{args.Hour}:{args.Min}:{args.Sec}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.clock.Work(22, 22, 22);//设定开始事件并开始
            Console.WriteLine("Hello World!");
        }
    }
}
