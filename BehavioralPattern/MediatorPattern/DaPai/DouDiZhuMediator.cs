using System.Collections.Generic;

namespace MediatorPattern.DaPai
{
    public class DouDiZhuMediator : AbsMediator
    {
        private List<Person> colleagues = new List<Person>();

        public override void Register(Person obj)
        {
            if (!this.colleagues.Contains(obj))
            {
                this.colleagues.Add(obj);
                obj.SetMediator(this);
            }
        }

        public override void HuCard(Person obj)
        {
            foreach (var item in this.colleagues)
            {
                item.ReceiveHuCard(obj);
            }
        }
    }
}