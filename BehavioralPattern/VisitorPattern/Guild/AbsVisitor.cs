namespace VisitorPattern.Guild
{
    public abstract class AbsVisitor
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="engineer"></param>
        /// <returns></returns>
        public abstract string Visit(UserPlatform engineer);

        public abstract string Visit(GuildPlatform manager);

        public abstract string Visit(GuildMemberPlatform guildMemberPlatform);
    }
}