namespace StatePattern.Lift
{
    public abstract class LiftState
    {
        protected LiftContext LiftContext;

        public void SetContext(LiftContext liftContext)
        {
            this.LiftContext = liftContext;
        }

        //电梯门开启动作
        public abstract void Open();

        //电梯门关闭动作
        public abstract void Close();

        //电梯运行
        public abstract void Run();

        //电梯停止
        public abstract void Stop();
    }
}