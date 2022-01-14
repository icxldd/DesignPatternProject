namespace CommandPattern.Common
{
    public class CommandLineArgs
    {
        public CommandLineArgs(string command, params string[] args)
        {
            Command = command;
            Args = args;
        }

        public string Command { get; }

        public string[] Args { get; }
    }
}