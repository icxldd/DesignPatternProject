using CommandPattern.Common;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var arg = args[1];
            var common = new CommandLineArgs(args[0], arg);
            if (args[0] == "god")
            {
                new GodConsoleCommand().ExecuteAsync(common);
            }

            if (args[0] == "kill")
            {
                new KillConsoleCommand().ExecuteAsync(common);
            }

            if (args[0] == "revive")
            {
                new ReviveConsoleCommand().ExecuteAsync(common);
            }
        }
    }
}