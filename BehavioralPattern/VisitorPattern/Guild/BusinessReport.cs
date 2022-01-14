using System.Collections.Generic;

namespace VisitorPattern.Guild
{
    public class BusinessReport
    {
        private List<AbsPlatform> _absPlatforms;

        public BusinessReport(List<AbsPlatform> absPlatforms)
        {
            _absPlatforms = absPlatforms;
        }

        public void ShowReport(AbsVisitor visitor)
        {
            foreach (var platform in _absPlatforms)
            {
                platform.Accept(visitor);
            }
        }
    }
}