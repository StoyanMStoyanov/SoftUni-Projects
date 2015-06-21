using System;
using System.Collections.Generic;

class AsynchronousTimer
{
    public delegate void Timer(Action<int> action, int ticks, int t);

    static void Main()
    {
        AsyncTimer timer = new AsyncTimer(Console.WriteLine, 10, 1000);
        timer.ExecuteMethod();
        AsyncTimer timer1 = new AsyncTimer(Console.Write, 20, 300);
        timer1.ExecuteMethod();
    }
}
