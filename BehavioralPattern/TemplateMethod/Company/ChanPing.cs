using System;

namespace TemplateMethod.Company
{
    public class ChanPing : AbsCompanyWork
    {
        protected override void ShangWu()
        {
            Console.WriteLine("上午：画需求");
        }

        protected override void XiaWu()
        {
            Console.WriteLine("下午：与程序员吵架");
        }
    }
}