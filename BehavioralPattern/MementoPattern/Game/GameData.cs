namespace MementoPattern.Game
{
    public class GameData
    {
        public double Money { get; set; }


        public int TaskLevel { get; set; }

        public int X { get; set; }

        public int Y { get; set; }


        public GameData(double money, int taskLevel, int x, int y, int fanZuiLevel)
        {
            Money = money;
            TaskLevel = taskLevel;
            X = x;
            Y = y;
            FanZuiLevel = fanZuiLevel;
        }


        public int FanZuiLevel { get; set; }
    }
}