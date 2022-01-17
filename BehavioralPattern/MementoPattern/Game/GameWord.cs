using System;

namespace MementoPattern.Game
{
    public class GameWord
    {
        public GameWord(GameData gameData)
        {
            GameData = gameData;
        }


        public GameMemento SaveState()
        {
            return new GameMemento(GameData);
        }

        public void ShowDisplay()
        {
            Console.WriteLine($"坐标：{GameData.X}:{GameData.Y},钱：{GameData.Money}");
        }

        public void Die()
        {
            this.GameData = null;
        }

        public void RecoveryState(GameMemento gameData)
        {
            GameData = gameData.GameData;
        }

        public GameData GameData { get; set; }
    }
}