using System;
using CompositePattern.Classify;
using CompositePattern.Organization;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ClassifyTest();


            var root = new RootComposite("总公司");

            var developmentDepartment = new DepartmentComposite("开发部");
            var renshiDepartment = new DepartmentComposite("人事");
            var chanpingDepartment = new DepartmentComposite("产品");
            root.Add(developmentDepartment);
            root.Add(renshiDepartment);
            root.Add(chanpingDepartment);
            var aRenshiDepartment = new GroupComposite("人事一组");
            renshiDepartment.Add(aRenshiDepartment);
            
            developmentDepartment.Add(new Person("程先龙"));
            developmentDepartment.Add(new Person("程先龙2"));
            aRenshiDepartment.Add(new Person("牛逼"));
            

            root.Display(0);
        }

        private static void ClassifyTest()
        {
            var root = new ProductClassifyComposite("商品");
            var yifu = new ProductClassifyComposite("衣服");
            var kuzi = new ProductClassifyComposite("裤子");
            var neiyi = new ProductClassifyComposite("内衣");
            root.Add(yifu);
            root.Add(kuzi);
            root.Add(neiyi);
            yifu.Add(new ProductLeaf("上衣"));
            kuzi.Add(new ProductLeaf("长裤"));
            kuzi.Add(new ProductLeaf("短裤"));

            root.Display(0);
        }
    }
}