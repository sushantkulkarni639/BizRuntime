using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Rx.net
{
    class RxObserver1 : IObserver<int>
    {
        public void OnNext(int value)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value on  thread {threadId}:{value}");
        }
        public void OnError(Exception error)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Error:{threadId}:{error.Message}");
        }
        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"completed{threadId}");
        }
    }
}
