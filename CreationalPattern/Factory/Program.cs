using System;
using Factory.AbsFactory;
using Factory.FactoryMethod;
using Factory.SimpleFactory.DBSimple;
using Factory.SimpleFactory.EmployeeSimple;
using Factory.SimpleFactory.LogProviderSimple;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleFactory();
            // FactoryMethod();
            AbsFactory();
        }


        static void AbsFactory()
        {
            new AbsFactoryUnitTest().Test();
        }

        static void FactoryMethod()
        {
            new FactoryMethodMessageProviderUnitTest().Test();
        }

        static void SimpleFactory()
        {
            // DbSimple.MainTest();
            // EmployeeSimple.MainTest();
            LogProviderFactorySimple.MainTest();
        }
    }
}