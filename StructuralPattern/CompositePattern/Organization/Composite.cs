using System;
using System.Collections.Generic;

namespace CompositePattern.Organization
{
    public abstract class Composite : AbsComponent
    {
        protected List<AbsComponent> Components { get; }

        public Composite(string name, NodeType nodeType) : base(name, nodeType)
        {
            Components = new List<AbsComponent>();
        }

        public override void Add(AbsComponent productComponent)
        {
            Components.Add(productComponent);
        }

        public override void Remove(AbsComponent productComponent)
        {
            Components.Remove(productComponent);
        }

        public override void Display(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("----");
            }

            Console.WriteLine(Name);

            foreach (var component in Components)
            {
                component.Display(depth + 1);
            }
        }
    }
}