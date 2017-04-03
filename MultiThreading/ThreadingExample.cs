using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    public class ThreadingExample
    {
        public void Run()
        {
            Thread t = new Thread(RunTasks);
            t.Start();
        }

        public void RunTasks()
        {
            Task.Factory.StartNew(() => DoWork(Thread.CurrentThread.ManagedThreadId));
            Task.Factory.StartNew(() => DoWork(Thread.CurrentThread.ManagedThreadId));
            Task.Factory.StartNew(() => DoWork(Thread.CurrentThread.ManagedThreadId));
        }

        private void DoWork(int threadid)
        {
            Console.WriteLine("I am running a task from threadID" + threadid.ToString());
        }
    }
}
