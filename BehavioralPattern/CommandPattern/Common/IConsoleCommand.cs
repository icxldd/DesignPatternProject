namespace CommandPattern.Common
{
    public interface IConsoleCommand
    {
        void ExecuteAsync(CommandLineArgs commandLineArgs);
    }
}