using System;

namespace MediatorPattern.DaPai
{
    public class DizhuPerson : Person
    {
        public DizhuPerson(string name) : base(name, PersonType.地主)
        {
        }

        public override void ReceiveHuCard(Person person)
        {
            AddQian(person);
            if (person.PersonType != PersonType.地主)
            {
                KouQian(person);

                Console.WriteLine("农民赢啦，地主扣钱------还剩" + Money + this.Name);
            }
        }
    }
}