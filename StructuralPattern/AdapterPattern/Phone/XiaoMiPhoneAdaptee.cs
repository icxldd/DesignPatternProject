using System;

public class XiaoMiPhoneAdaptee : AbsPhoneAdaptee
{
    public override void Charger()
    {
        Console.WriteLine("小米充电");
    }

    public override void Shutdown()
    {
        Console.WriteLine("小米关机");
    }

    public override void StartUp()
    {
        Console.WriteLine("小米开机");
    }
}