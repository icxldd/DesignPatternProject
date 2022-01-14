namespace StatePattern.Game
{
    public abstract class AbsGameLiftState
    {
        protected GameContext GameContext { get; set; }
        public abstract void DingDianDaGuai(string cityName);

        public abstract void ShuaFuBen(string fuBenName);

        public abstract void DaZuo();

  

        public bool IsIdle()
        {
            if (GameContext.GetGameState() == GameContext.IDLE_STATE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetContext(GameContext gameContext)
        {
            this.GameContext = gameContext;
        }
    }
}