using System.Linq;

namespace MediatorPattern.DaPai
{
    public abstract class AbsMediator
    {
        public abstract void Register(Person obj);

        /// <summary>
        /// 赢牌
        /// </summary>
        /// <param name="obj"></param>
        public abstract void HuCard(Person obj);
    }
}