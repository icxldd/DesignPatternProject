using System;

namespace CompositePattern.Classify
{
    /// <summary>
    /// 商品
    /// </summary>
    public class ProductLeaf : AbsProductComponent
    {
        public ProductLeaf(string name) : base(name)
        {
        }

        public override void Add(AbsProductComponent productComponent)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(AbsProductComponent productComponent)
        {
            throw new System.NotImplementedException();
        }

        public override void Display(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("----");
            }

            Console.WriteLine(Name);
        }
    }
}