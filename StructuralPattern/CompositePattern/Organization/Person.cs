using System;

namespace CompositePattern.Organization
{
    public class Person : AbsComponent
    {
        public Person(string name) : base(name,NodeType.Person)
        {
        }

        public override void Add(AbsComponent productComponent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(AbsComponent productComponent)
        {
            throw new NotImplementedException();
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