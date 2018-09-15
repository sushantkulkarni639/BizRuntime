using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading;
using System.Reactive;

namespace Rx.net
{
    class RxObservable
    {
        static void Main(string[] args)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"program started with main thread with Id {threadId}");
            var observable = Observable.Range(5, 6 );
            var subscription = observable.Subscribe(new RxObserver1());
            subscription.Dispose();
            Console.Read();


        }
    }
}
