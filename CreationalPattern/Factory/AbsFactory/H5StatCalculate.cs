using System;

namespace Factory.AbsFactory
{
    public class H5StatCalculate : IStatCalculate
    {
        public void CalcTodayData()
        {
            Console.WriteLine($"H5:统计今日数据完成");
        }
    }
}