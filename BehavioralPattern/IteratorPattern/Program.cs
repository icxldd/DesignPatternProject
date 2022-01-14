using System;
using System.Collections;
using System.Collections.Generic;
using IteratorPattern.Core;
using IteratorPattern.Enumerable;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreTest();

            // EnumerableTest();
        }

        private static void EnumerableTest()
        {
            var queueEnumerable = new QueueEnumerable(new List<string>() {"cxl", "张三", "李四", "王五"});

            foreach (var name in queueEnumerable)
            {
                Console.WriteLine(name + "排队买好了蛋炒饭");
            }
        }

        private static void CoreTest()
        {
            ArrayAggregate<string> arrayAggregate = new ArrayAggregate<string>(new string[] {"cxl", "张三", "李四", "王五"});

            var iterator = arrayAggregate.GetIterator();
            while (iterator.HasNext())
            {
                iterator.MoveNext();
                Console.WriteLine(iterator.Current + "排队买好了蛋炒饭");
            }
        }
    }
}