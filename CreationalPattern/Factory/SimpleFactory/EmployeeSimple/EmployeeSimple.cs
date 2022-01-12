using System;

namespace Factory.SimpleFactory.EmployeeSimple
{
    public static class EmployeeSimple
    {
        public static void MainTest()
        {
            while (true)
            {
                Console.WriteLine("请输入1|2|3");
                EmployeeType inputType = Enum.Parse<EmployeeType>(Console.ReadLine()!);

                var provider = EmployeeProviderFactory.CreateDbProvider(inputType);
                
                provider.Work();

            }
        }
    }
}