using System;

namespace CommandPattern.Common
{
    public class GodConsoleCommand : IConsoleCommand
    {
        public void ExecuteAsync(CommandLineArgs commandLineArgs)
        {
            Console.WriteLine($"给{commandLineArgs.Args[0]}增加无敌BUFF");
        }
    }
}