using System;

namespace StatePattern.Game
{
    public class DaZuoGameLiftState : AbsGameLiftState
    {
        /// <summary>
        /// 取消打坐
        /// </summary>
        private void CancelDaZuo()
        {
        }

        public override void DingDianDaGuai(string cityName)
        {
            CancelDaZuo();
            GameContext.SetGameState(GameContext.DingDianDaGuai_STATE);
            GameContext.DingDianDaGuai(cityName);
        }

        public override void ShuaFuBen(string fuBenName)
        {
            CancelDaZuo();
            GameContext.SetGameState(GameContext.ShuaFuBen_STATE);
            GameContext.ShuaFuBen(fuBenName);
        }

        public override void DaZuo()
        {
            Console.WriteLine("开始打坐");
        }
    }
}