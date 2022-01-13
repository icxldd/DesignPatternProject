using System;

public class IosPhoneAdaptee : AbsPhoneAdaptee
{
    public override void Charger()
    {
        Console.WriteLine("苹果充电");
    }

    public override void Shutdown()
    {
        Console.WriteLine("苹果关机");
    }

    public override void StartUp()
    {
        Console.WriteLine("苹果开机");
    }
}