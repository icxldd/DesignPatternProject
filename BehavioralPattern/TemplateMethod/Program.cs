using System;
using TemplateMethod.BuyVegetable;
using TemplateMethod.Company;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // BuyVegetableTest();
            
            new Boss().Work();
            new ChanPing().Work();
            new JiShu().Work();
        }

        private static void BuyVegetableTest()
        {
            new OwnerBuyVegetable().BuyVegetable();
            new MaMaBuyVegetable().BuyVegetable();
            new BaBaBuyVegetable().BuyVegetable();
        }
    }
}