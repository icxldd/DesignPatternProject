namespace ChainOfResponsibilityPattern.Guild
{
    public abstract class AbsGuildManager
    {
        private string _name;
        protected AbsGuildManager SuperiorGuildManager { get; }


        protected AbsGuildManager(string name, AbsGuildManager superiorGuildManager)
        {
            _name = name;
            SuperiorGuildManager = superiorGuildManager;
        }

        public abstract void HandlerRequest(GuildRequest request);
    }
}