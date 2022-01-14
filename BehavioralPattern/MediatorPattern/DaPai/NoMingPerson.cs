using System;

namespace MediatorPattern.DaPai
{
    public class NoMingPerson : Person
    {
        public NoMingPerson(string name) : base(name, PersonType.农民)
        {
        }

        public override void ReceiveHuCard(Person person)
        {
            AddQian(person);
            if (person.PersonType != PersonType.农民)
            {
                KouQian(person);

                Console.WriteLine("地主赢啦，农民扣钱------还剩" + Money + this.Name);
            }
        }
    }
}