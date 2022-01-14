using System;
using MediatorPattern.DaPai;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DizhuTest();

            // NongmingTest();
        }

        private static void NongmingTest()
        {
            var doudizhu = new DouDiZhuMediator();

            var dizhu = new DizhuPerson("地主");
            var nongminga = new NoMingPerson("A农民");
            var nongmingb = new NoMingPerson("B农民");
            doudizhu.Register(dizhu);
            doudizhu.Register(nongminga);
            doudizhu.Register(nongmingb);

            nongminga.HuCard();

            Console.WriteLine(nongminga.Money + "," + nongmingb.Money);
        }

        private static void DizhuTest()
        {
            var doudizhu = new DouDiZhuMediator();

            var dizhu = new DizhuPerson("地主");
            var nongminga = new NoMingPerson("A农民");
            var nongmingb = new NoMingPerson("B农民");
            doudizhu.Register(dizhu);
            doudizhu.Register(nongminga);
            doudizhu.Register(nongmingb);

            dizhu.HuCard();

            Console.WriteLine(dizhu.Money);
        }
    }
}