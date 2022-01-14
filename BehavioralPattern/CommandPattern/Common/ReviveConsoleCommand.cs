using System;

namespace CommandPattern.Common
{
    public class ReviveConsoleCommand : IConsoleCommand
    {
        public void ExecuteAsync(CommandLineArgs commandLineArgs)
        {
            Console.WriteLine($"复活{commandLineArgs.Args[0]}");
        }
    }
}