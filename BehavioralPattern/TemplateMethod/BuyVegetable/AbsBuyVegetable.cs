using System;

namespace TemplateMethod.BuyVegetable
{
    public abstract class AbsBuyVegetable
    {
        public virtual void BuyVegetable()
        {
            BuyShuCai();
            BuyMeat();
            BuyComplete();
        }

        /// <summary>
        /// 买蔬菜
        /// </summary>
        protected virtual void BuyShuCai()
        {
            Console.WriteLine("随便买点蔬菜");
        }

        /// <summary>
        /// 买肉
        /// </summary>
        protected virtual void BuyMeat()
        {
            Console.WriteLine("随便买点肉");
        }


        /// <summary>
        /// 购买完成回调
        /// </summary>
        protected virtual void BuyComplete()
        {
        }
    }
}