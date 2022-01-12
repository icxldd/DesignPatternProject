using System;

namespace Factory.SimpleFactory.EmployeeSimple
{
    public class ReceptionProvider : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("前台招待");
        }
    }
}