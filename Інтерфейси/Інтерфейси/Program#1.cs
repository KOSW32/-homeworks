using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        // Завдання 1
        IRemoteControl tv = new TvRemoteControl();
        tv.TurnOn();
        tv.SetChannel(5);
        tv.TurnOff();

        Console.WriteLine();

        IRemoteControl radio = new RadioRemoteControl();
        radio.TurnOn();
        radio.SetChannel(101);
        radio.TurnOff();

        Console.WriteLine("\n--- Перевірка даних ---");

        // Завдання 2
        IValidator emailValidator = new EmailValidator("test@mail.com");
        IValidator passwordValidator = new PasswordValidator("123456");

        Console.WriteLine("Email коректний: " + emailValidator.Validate());
        Console.WriteLine("Пароль коректний: " + passwordValidator.Validate());
    }
}
