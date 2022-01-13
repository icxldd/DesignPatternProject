using System;
using FlyweightPattern.Core;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FontFlyWeight a, b;
            a = FontFactory.GetInstance.FindFont(FontA.NAME);
            
            var aa = FontFactory.GetInstance.FindFont(FontA.NAME);
            if (a.GetHashCode().Equals(aa.GetHashCode()))
            {
                Console.WriteLine("相同对象");
            }
            // a.SetColor("red");
            // a.SetSize("80px");
            // b = FontFactory.GetInstance.FindFont(FontB.NAME);
            // b.SetColor("blue");
            // b.SetSize("80px");
        
        }
    }
}