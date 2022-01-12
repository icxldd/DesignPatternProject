using System;

namespace Factory.SimpleFactory.LogProviderSimple
{
    public static class LogProviderFactorySimple
    {
        public static void MainTest()
        {
            while (true)
            {
                Console.WriteLine("请输入1|2");
                LogProviderType inputType = Enum.Parse<LogProviderType>(Console.ReadLine()!);

                var provider = LogProviderFactory.Create(inputType);

                int aa = new Random(100).Next(30);
                provider.WriteLog(aa.ToString());
            }
        }
    }
}