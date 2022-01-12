using System;

namespace Factory.SimpleFactory.EmployeeSimple
{
    public class ProgrammerProvider : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("写代码");
        }
    }
}