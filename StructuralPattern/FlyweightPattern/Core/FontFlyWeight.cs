using System;

namespace FlyweightPattern.Core
{
    public class FontFlyWeight
    {
        //享元对象标识，用于作为存入键值对中的键值
        public const string NAME = "";
        private char fontContent;

        public char FontContent
        {
            get => fontContent;
            set => fontContent = value;
        }

        public FontFlyWeight(char font)
        {
            fontContent = font;
        }

        public string SetColor(string color)
        {
            Console.WriteLine($"将当前字体{FontContent}的字体颜色设置为{color}");
            return color;
        }

        public string SetSize(string size)
        {
            Console.WriteLine($"将当前字体{FontContent}的字体大小设置为{size}");
            return size;
        }
    }
}