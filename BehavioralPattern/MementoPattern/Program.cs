using System;
using MementoPattern.Game;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData gameData = new GameData(100, 1, 100, 20, 2);
            GameWord gameWord = new GameWord(gameData);
            gameWord.ShowDisplay();
            GameCaretaker gameCaretaker = new GameCaretaker();
            gameCaretaker.SetGameMemento(gameWord.SaveState());
            gameWord.Die();
            gameWord.RecoveryState(gameCaretaker.GetGameMemento);
            gameWord.ShowDisplay();
            Console.WriteLine("Hello World!");
        }
    }
}