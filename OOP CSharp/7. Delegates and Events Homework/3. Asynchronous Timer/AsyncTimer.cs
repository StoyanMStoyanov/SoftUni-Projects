using System;
using System.Threading;

public class AsyncTimer
{
    private readonly Action<int> methodExecute;
    private int ticks;
    private int t;

    public AsyncTimer(Action<int> methodExecute, int ticks, int t)
    {
        this.methodExecute = methodExecute;
        this.Ticks = ticks;
        this.T = t;
    }
    public int Ticks
    {
        get
        {
            return this.ticks;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("ticks", "The method should be executed at least once.");
            }
            this.ticks = value;
        }
    }
    public int T
    {
        get
        {
            return this.t;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("t", "The sleep time cannot be negative.");
            }
            this.t = value;
        }
    }

    public void ExecuteMethod()
    {
        Thread parallelThread = new Thread(this.SomeMethod);
        parallelThread.Start();
    }

    private void SomeMethod()
    {
        for (int ticks = 0; ticks < this.Ticks; ticks++)
        {
            if (this.methodExecute != null)
                methodExecute(ticks);
            Thread.Sleep(this.T); 
        }       
        
    }

}
