using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading;

namespace Rx.net
{
    class ObservableRange :IObservable<int>
    {
        private int _start;
        private int _count;

        public ObservableRange(int start, int count)
        {
            this._start = start;
            this._count = count;
        }
        public IDisposable Subscribe(IObserver<int> observer)
        {
            try
            {
                for(int i=_start; i<_start+_count;i++)
                {
                    observer.OnNext(i);
                }
                observer.OnCompleted();
                return new MyDisposable();
            }
            catch(Exception ex)
            {
                observer.OnError(ex);
                return new MyDisposable();
            }
        }
    }
}
