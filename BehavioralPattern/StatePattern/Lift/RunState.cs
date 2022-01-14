using System;

namespace StatePattern.Lift
{
    public class RunState : LiftState
    {
        public override void Open()
        {
        }

        public override void Close()
        {
        }

        public override void Run()
        {
            Console.WriteLine("电梯开始运行");
        }

        public override void Stop()
        {
            LiftContext.SetLiftState(LiftContext.STOPPING_STATE);
            LiftContext.Stop();
        }
    }
}