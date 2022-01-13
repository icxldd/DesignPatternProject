using System.Threading.Tasks;

/// <summary>
/// 抽象Adaptee
/// </summary>
public abstract class AbsPhoneAdaptee
{
    //充电
    public abstract void Charger();

    public abstract void Shutdown();

    public abstract void StartUp();
}