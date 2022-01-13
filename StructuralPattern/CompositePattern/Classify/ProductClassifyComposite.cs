using System;
using System.Collections.Generic;

namespace CompositePattern.Classify
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class ProductClassifyComposite : AbsProductComponent
    {
        private readonly List<AbsProductComponent> _productComponents;

        public ProductClassifyComposite(string name) : base(name)
        {
            _productComponents = new List<AbsProductComponent>();
        }

        public override void Add(AbsProductComponent productComponent)
        {
            _productComponents.Add(productComponent);
        }

        public override void Remove(AbsProductComponent productComponent)
        {
            _productComponents.Remove(productComponent);
        }

        public override void Display(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("----");
            }

            Console.WriteLine(Name);

            foreach (var component in _productComponents)
            {
                component.Display(depth + 1);
            }
        }
    }
}