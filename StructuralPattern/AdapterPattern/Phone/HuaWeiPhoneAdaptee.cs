using System;

public class HuaWeiPhoneAdaptee : AbsPhoneAdaptee
{
    public override void Charger()
    {
        Console.WriteLine("华为充电");
    }

    public override void Shutdown()
    {
        Console.WriteLine("华为关机");
    }

    public override void StartUp()
    {
        Console.WriteLine("华为开机");
    }
}