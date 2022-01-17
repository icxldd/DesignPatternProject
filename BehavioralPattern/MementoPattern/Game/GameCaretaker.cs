namespace MementoPattern.Game
{
    public class GameCaretaker
    {
        

        public GameMemento GameMemento { get; set; }

        public GameMemento GetGameMemento => GameMemento;


        public void SetGameMemento(GameMemento gameMemento)
        {
            GameMemento = gameMemento;
        }
    }
}