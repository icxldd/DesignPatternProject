using VisitorPattern.Guild.Domain;

namespace VisitorPattern.Guild
{
    public class UserPlatform : AbsPlatform
    {
        public User _user;

        public UserPlatform(User user)
        {
            _user = user;
        }

        public override void Accept(AbsVisitor absVisitor)
        {
            absVisitor.Visit(this);
        }
    }
}