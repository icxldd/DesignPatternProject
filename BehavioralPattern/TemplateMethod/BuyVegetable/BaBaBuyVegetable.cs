using System;

namespace TemplateMethod.BuyVegetable
{
    public class BaBaBuyVegetable : AbsBuyVegetable
    {
        protected override void BuyMeat()
        {
            Console.WriteLine("爸爸买肉食：鱼");
        }

        protected override void BuyShuCai()
        {
            Console.WriteLine("爸爸买蔬菜：海带");
        }

        protected override void BuyComplete()
        {
            Console.WriteLine("爸爸买菜完毕");
        }
    }
}