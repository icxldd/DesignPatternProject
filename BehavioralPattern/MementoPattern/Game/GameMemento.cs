namespace MementoPattern.Game
{
    public class GameMemento
    {
        public GameMemento(GameData gameData)
        {
            GameData = gameData;
        }

        public GameData GameData { get; set; }
    }
}