namespace StatePattern.Lift
{
    public class LiftContext
    {
        public LiftContext()
        {
            SetLiftState(CLOSING_STATE);
        }

        //定义出电梯的所有状态
        public readonly static LiftState OPENNING_STATE = new OpenState();
        public readonly static LiftState CLOSING_STATE = new CloseState();
        public readonly static LiftState RUNNING_STATE = new RunState();
        public readonly static LiftState STOPPING_STATE = new StopState();

        //定义一个当前电梯状态
        private LiftState LiftState;

        public LiftState GetLiftState()
        {
            return LiftState;
        }

        public void SetLiftState(LiftState liftState)
        {
            this.LiftState = liftState;
            //通知到各个实现类中
            this.LiftState.SetContext(this);
        }

        public void Open()
        {
            this.LiftState.Open();
        }

        public void Close()
        {
            this.LiftState.Close();
        }

        public void Run()
        {
            this.LiftState.Run();
        }

        public void Stop()
        {
            this.LiftState.Stop();
        }
    }
}