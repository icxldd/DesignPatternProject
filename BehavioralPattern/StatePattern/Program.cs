using System;
using StatePattern.Game;
using StatePattern.Lift;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // LiftTest();
            GameStateTest();
        }

        private static void GameStateTest()
        {
            var gameContext = new GameContext();
            gameContext.DaZuo();
            gameContext.DingDianDaGuai("椰城");
            gameContext.ShuaFuBen("牛逼");
        }

        private static void LiftTest()
        {
            LiftContext liftContext = new LiftContext();
            liftContext.Open();
            liftContext.Close();
            liftContext.Run();
            liftContext.Stop();
        }
    }
}