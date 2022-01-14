using System;

namespace CommandPattern.Common
{
    public class KillConsoleCommand : IConsoleCommand
    {
        public void ExecuteAsync(CommandLineArgs commandLineArgs)
        {
            Console.WriteLine($"杀死{commandLineArgs.Args[0]}");
        }
    }
}