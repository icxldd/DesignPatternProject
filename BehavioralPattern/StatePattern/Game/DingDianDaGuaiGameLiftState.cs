using System;

namespace StatePattern.Game
{
    public class DingDianDaGuaiGameLiftState : AbsGameLiftState
    {
        public override void DingDianDaGuai(string cityName)
        {
            Console.WriteLine($"在{cityName}开始定点打怪");
        }

        public override void ShuaFuBen(string fuBenName)
        {
            //定点打怪区域时候不能去刷副本
        }

        public override void DaZuo()
        {
            //打怪区域不能打坐
        }
    }
}