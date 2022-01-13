using System.Collections.Generic;

namespace FlyweightPattern.Core
{
    public class FontFactory
    {
        private static FontFactory m_instance;

        public static FontFactory GetInstance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new FontFactory();
                }
                return m_instance;
            }
        }

        private FontFactory()
        {
            AddFont(FontA.NAME, new FontA('a'));
            AddFont(FontB.NAME, new FontB('b'));
        }
        
        private Dictionary<string, FontFlyWeight> m_fontDic =
            new Dictionary<string, FontFlyWeight>();

        public void AddFont(string fontName, FontFlyWeight font)
        {
            if (m_fontDic.ContainsKey(fontName))
            {
                m_fontDic[fontName] = font;
            }
            else
            {
                m_fontDic.Add(fontName, font);
            }
        }

        public FontFlyWeight FindFont(string fontName)
        {
            if (m_fontDic.ContainsKey(fontName))
            {
                return m_fontDic[fontName];
            }

            return null;
        }

        public void RemoveFont(string fontName)
        {
            if (m_fontDic.ContainsKey(fontName))
            {
                m_fontDic.Remove(fontName);
            }
        }
    }
}