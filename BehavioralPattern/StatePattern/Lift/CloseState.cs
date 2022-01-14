using System;

namespace StatePattern.Lift
{
    public class CloseState : LiftState
    {
        public override void Open()
        {
            LiftContext.SetLiftState(LiftContext.OPENNING_STATE);
            LiftContext.Open();
        }

        public override void Close()
        {
            Console.WriteLine("电梯门关闭");
        }

        public override void Run()
        {
            LiftContext.SetLiftState(LiftContext.RUNNING_STATE);
            LiftContext.Run();
        }

        public override void Stop()
        {
            LiftContext.SetLiftState(LiftContext.STOPPING_STATE);
            LiftContext.Stop();
        }
    }
}