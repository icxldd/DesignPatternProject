using System;
using Factory.SimpleFactory.DBSimple;
using Factory.SimpleFactory.EmployeeSimple;
using Factory.SimpleFactory.LogProviderSimple;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory();
        }

        static void SimpleFactory()
        {
            // DbSimple.MainTest();
            // EmployeeSimple.MainTest();
            LogProviderFactorySimple.MainTest();
        }
    }
}