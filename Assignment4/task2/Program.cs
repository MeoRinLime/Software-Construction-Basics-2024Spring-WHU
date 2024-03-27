using System;
using System.Threading;

public class Clock
{
    // 定义委托
    public delegate void ClockHandler(object sender, EventArgs e);

    // 定义事件
    public event ClockHandler? Tick;
    public event ClockHandler? Alarm;

    // 触发事件的方法
    protected virtual void OnTick(EventArgs e)
    {
        Tick?.Invoke(this, e);
    }

    protected virtual void OnAlarm(EventArgs e)
    {
        Alarm?.Invoke(this, e);
    }

    // 闹钟运行方法
    public void Run()
    {
/*        Task.Run(() =>
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnTick(EventArgs.Empty);
            }
        });

        Task.Run( () =>
        {
            while (true)
            {
                Thread.Sleep(10000); 
                OnAlarm(EventArgs.Empty);
            }
        });*/
        while (true)
        {
            Thread.Sleep(1000); // 每秒Tick一次
            OnTick(EventArgs.Empty);

            DateTime now = DateTime.Now;
            if (now.Second % 10 == 0) // 每10秒Alarm一次
            {
                OnAlarm(EventArgs.Empty);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        // 注册事件
        clock.Tick += (sender, e) => Console.WriteLine("Tick...");
        clock.Alarm += (sender, e) => Console.WriteLine("Alarm!");

        // 运行闹钟
        clock.Run();
    }
}
