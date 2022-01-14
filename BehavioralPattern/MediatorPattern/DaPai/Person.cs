namespace MediatorPattern.DaPai
{
    public abstract class Person
    {
        protected AbsMediator AbsMediator { get; set; }

        public Person(string name, PersonType personType)
        {
            Name = name;
            PersonType = personType;
            Money = 100;
        }

        public void SetMediator(AbsMediator mediator)
        {
            AbsMediator = mediator;
        }

        public string Name { get; }
        public PersonType PersonType { get; }
        public int Money { get; set; }

        public void HuCard()
        {
            AbsMediator.HuCard(this);
        }

        public abstract void ReceiveHuCard(Person person);


        protected void AddQian(Person huPerson)
        {
            if (huPerson.PersonType == PersonType)
            {
                if (PersonType == PersonType.农民)
                {
                    Money += 10;
                }
                else if (PersonType == PersonType.地主)
                {
                    Money += 40;
                }
            }
        }

        protected void KouQian(Person huPerson)
        {
            if (huPerson.PersonType == PersonType.农民)
            {
                Money -= 20;
            }
            else if (huPerson.PersonType == PersonType.地主)
            {
                Money -= 20;
            }
        }
    }
}