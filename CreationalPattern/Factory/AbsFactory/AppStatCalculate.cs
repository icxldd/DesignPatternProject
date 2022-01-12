using System;

namespace Factory.AbsFactory
{
    public class AppStatCalculate : IStatCalculate
    {
        public void CalcTodayData()
        {
            Console.WriteLine($"App:统计今日数据完成");
        }
    }
}