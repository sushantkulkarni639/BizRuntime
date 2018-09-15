using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    internal class MyObserver<T> :IObserver<T>
    {
        private string name = null;
        public MyObserver(string subscriberName ="Subscriber1")
        {
            name = subscriberName;
        }
        public virtual void OnCompleted()
        {
            Console.WriteLine($"Observation copmleted by{name}");
        }
        public virtual void OnError(Exception ex)
        {
            Console.WriteLine($"Error occured while {name} was observing{ex.Message}");
        }
        public virtual void OnNext(T value)
        {
            Console.WriteLine($"{name} received:{value.ToString()}");
        }
    }
}
