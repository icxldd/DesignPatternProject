using System;

namespace TemplateMethod.Company
{
    public class JiShu : AbsCompanyWork
    {
        protected override void ShangWu()
        {
            Console.WriteLine("上午：敲代码");
        }

        protected override void XiaWu()
        {
            Console.WriteLine("下午：改Bug");
        }
    }
}