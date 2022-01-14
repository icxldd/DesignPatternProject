namespace VisitorPattern.Guild
{
    public abstract class AbsPlatform
    {
        /// <summary>
        /// visitor 获取数据
        /// </summary>
        /// <param name="absVisitor"></param>
        /// <returns></returns>
        public abstract string Accept(AbsVisitor absVisitor);
    }
}