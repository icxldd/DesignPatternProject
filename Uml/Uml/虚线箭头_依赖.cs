namespace Uml
{
    //虚线三角形-》指向依赖

    //all -> 依赖关系
    //代码表现：局部变量，方法参数，静态引用    

    public partial class Common
    {
    }

    public class Common2
    {
    }

    public static class Common3
    {
        public static void Simple()
        {
        }
    }


    public partial class Cxl
    {
        public Cxl()
        {
            var dd = new Common2();
            Common3.Simple();
        }

        public void Eat(Common common)
        {
        }
    }
}