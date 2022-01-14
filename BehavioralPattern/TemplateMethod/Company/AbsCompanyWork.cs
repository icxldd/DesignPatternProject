using System;

namespace TemplateMethod.Company
{
    public abstract class AbsCompanyWork
    {
        public void Work()
        {
            ShangWu();
            XiaWu();
        }


        protected virtual void ShangWu()
        {
            Console.WriteLine("上午：啥也不干");
        }

        protected virtual void XiaWu()
        {
            Console.WriteLine("上午：啥也不干");
        }
    }
}