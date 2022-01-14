using System;

namespace TemplateMethod.BuyVegetable
{
    public class OwnerBuyVegetable : AbsBuyVegetable
    {
        protected override void BuyMeat()
        {
            Console.WriteLine("自己买肉食：大羊排");
        }

        protected override void BuyShuCai()
        {
            Console.WriteLine("自己买蔬菜：不买");
        }

        protected override void BuyComplete()
        {
            Console.WriteLine("自己买菜完毕");
        }
    }
}