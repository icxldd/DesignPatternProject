using System;

namespace StatePattern.Lift
{
    public class OpenState : LiftState
    {
        public override void Open()
        {
            Console.WriteLine("电梯门开启");
        }

        public override void Close()
        {
            LiftContext.SetLiftState(LiftContext.CLOSING_STATE);
            LiftContext.Close();
        }

        public override void Run()
        {
        }

        public override void Stop()
        {
        }
    }
}