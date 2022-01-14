using System;

namespace TemplateMethod.Company
{
    public class Boss : AbsCompanyWork
    {
        protected override void ShangWu()
        {
            Console.WriteLine("上午：睡觉");
        }

        protected override void XiaWu()
        {
            Console.WriteLine("下午：数钱");
        }
    }
}