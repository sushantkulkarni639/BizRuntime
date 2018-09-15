﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class BehaviorSubject
    {
        static void Main(string[] args)
        
            {
                var subject = new BehaviorSubject<string>("a");
                subject.OnNext("b");
                subject.Subscribe(Console.WriteLine);
                subject.OnNext("c");
                subject.OnNext("d");
                Console.Read();
            }   
    }
}
