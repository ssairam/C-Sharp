using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BBQuestions_CarreerCup
{
    public class SingletonClass
    {
        private static readonly object _lock = new object();
        private static volatile SingletonClass _instance;

        private static class SingletonHolder {
            internal static SingletonClass _instance = new SingletonClass();
            static SingletonHolder() { }
        }

        private SingletonClass()
        { }

        public static SingletonClass GetSmartInstance {
            get { return SingletonHolder._instance; }
        }


        public static SingletonClass GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                            _instance = new SingletonClass();
                        }
                    }
                }
                return _instance;
            }
        }

        public string Write()
        { return Thread.CurrentThread.ManagedThreadId.ToString(); }
    }


}
