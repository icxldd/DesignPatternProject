using System;

namespace StatePattern.Lift
{
    public class StopState : LiftState
    {
        public override void Open()
        {
            LiftContext.SetLiftState(LiftContext.OPENNING_STATE);
            LiftContext.Open();
        }

        public override void Close()
        {
        }

        public override void Run()
        {
            LiftContext.SetLiftState(LiftContext.RUNNING_STATE);
            LiftContext.Run();
        }

        public override void Stop()
        {
            Console.WriteLine("电梯停止了");
        }
    }
}