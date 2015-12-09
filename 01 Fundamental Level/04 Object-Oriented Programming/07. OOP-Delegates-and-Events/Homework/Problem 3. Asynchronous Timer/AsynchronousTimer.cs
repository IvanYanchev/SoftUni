using System;
using System.Threading;

namespace Problem_3.Asynchronous_Timer
{
    public class AsynchronousTimer
    {
        public AsynchronousTimer(Action<DateTime> action, int ticks, int t)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.T = t;
        }

        private Action<DateTime> Action { get; set; }

        private int Ticks { get; set; }

        private int T { get; set; }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        private void Execute()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.T);
                this.Action(DateTime.Now);
            }
        }
    }
}
