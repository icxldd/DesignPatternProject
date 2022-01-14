using System;

namespace StatePattern.Game
{
    public class ShuaFuBenGameLiftState : AbsGameLiftState
    {
        public override void DingDianDaGuai(string cityName)
        {
            //刷副本区域不能定点打怪
        }

        public override void ShuaFuBen(string fuBenName)
        {
            Console.WriteLine($"开始刷副本{fuBenName}");
        }

        public override void DaZuo()
        {
            //刷副本区域不能打坐
        }
    }
}