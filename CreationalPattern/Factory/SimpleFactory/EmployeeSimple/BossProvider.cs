using System;

namespace Factory.SimpleFactory.EmployeeSimple
{
    public class BossProvider : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("数钱");
        }
    }
}