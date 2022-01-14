using System;

namespace TemplateMethod.BuyVegetable
{
    public class MaMaBuyVegetable : AbsBuyVegetable
    {
        protected override void BuyMeat()
        {
            Console.WriteLine("妈妈买肉食：羊肉，牛肉");
        }

        protected override void BuyShuCai()
        {
            Console.WriteLine("妈妈买蔬菜：青菜");
        }

        protected override void BuyComplete()
        {
            Console.WriteLine("妈妈买菜完毕");
        }
    }
}