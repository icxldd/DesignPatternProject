namespace FlyweightPattern.Core
{
    public class FontB : FontFlyWeight
    {
        public new const string NAME = "FontB";
        public FontB(char font) : base(font)
        {
        }
    }
}