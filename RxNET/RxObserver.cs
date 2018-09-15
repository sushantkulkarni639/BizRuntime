using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;

namespace Rx.net
{
    class RxObserver : IObserver<int>
    {
        public void OnNext(int value)
        {
            Console.WriteLine(value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine($"Error:{error.Message}");
        }
        public void OnCompleted()
        {
            Console.WriteLine("completed");
        }
    }
}
