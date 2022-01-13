namespace FlyweightPattern.Core
{
    public class FontA : FontFlyWeight
    {
        public new const string NAME = "FontA";
        public FontA(char font) : base(font)
        {
        }
    }
}