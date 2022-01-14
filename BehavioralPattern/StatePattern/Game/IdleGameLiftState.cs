namespace StatePattern.Game
{
    public class IdleGameLiftState : AbsGameLiftState
    {
        public override void DingDianDaGuai(string cityName)
        {
            GameContext.SetGameState(GameContext.DingDianDaGuai_STATE);
            GameContext.DingDianDaGuai(cityName);
        }

        public override void ShuaFuBen(string fuBenName)
        {
            GameContext.SetGameState(GameContext.ShuaFuBen_STATE);
            GameContext.ShuaFuBen(fuBenName);
        }

        public override void DaZuo()
        {
            GameContext.SetGameState(GameContext.DaZuo_STATE);
            GameContext.DaZuo();
        }
    }
}