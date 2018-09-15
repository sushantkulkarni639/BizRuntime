using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class RxObservable1
    {
        static void Main(string[] args)
        {
            Demo();
            Console.WriteLine("press to exit");
            
        }
        static void Demo()
        {
            var observable = new ObservableRange(5,8);
            var observer = new MyObserver<int>();
            var subscription = observable.Subscribe(observer);
            Console.WriteLine("press key to dispose subscription");
            Console.Read();
            subscription.Dispose();
        }
    }
}
