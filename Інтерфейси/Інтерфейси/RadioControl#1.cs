using System;

public class RadioRemoteControl : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Радіо увімкнено");
    }

    public void TurnOff()
    {
        Console.WriteLine("Радіо вимкнено");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Радіо: частота " + channel);
    }
}
