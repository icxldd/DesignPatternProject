namespace StatePattern.Game
{
    //* 外挂-》定点打怪，刷副本，打坐，闲着
    public class GameContext
    {
        public readonly static AbsGameLiftState DingDianDaGuai_STATE = new DingDianDaGuaiGameLiftState();
        public readonly static AbsGameLiftState ShuaFuBen_STATE = new ShuaFuBenGameLiftState();
        public readonly static AbsGameLiftState DaZuo_STATE = new DaZuoGameLiftState();
        public readonly static AbsGameLiftState IDLE_STATE = new IdleGameLiftState();

        public GameContext()
        {
            SetGameState(IDLE_STATE);
        }

        private AbsGameLiftState GameState;

        public AbsGameLiftState GetGameState()
        {
            return GameState;
        }
        public void SwitchIdleState()
        {
           SetGameState(GameContext.IDLE_STATE);
        }
        public void SetGameState(AbsGameLiftState gameState)
        {
            this.GameState = gameState;
            //通知到各个实现类中
            this.GameState.SetContext(this);
        }

        public void DingDianDaGuai(string cityName)
        {
            this.GameState.DingDianDaGuai(cityName);
        }

        public void ShuaFuBen(string fuBenName)
        {
            this.GameState.ShuaFuBen(fuBenName);
        }

        public void DaZuo()
        {
            this.GameState.DaZuo();
        }
    }
}