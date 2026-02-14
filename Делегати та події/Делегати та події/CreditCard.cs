using System;

public class CreditCard
{
    public string CardNumber { get; }
    public string OwnerName { get; }
    public string ExpiryDate { get; }
    public int Pin { get; private set; }
    public double CreditLimit { get; }
    public double Balance { get; private set; }


    public event Action<string>? OnDeposit;
    public event Action<string>? OnWithdraw;
    public event Action<string>? OnCreditStart;
    public event Action<string>? OnLimitReached;
    public event Action<string>? OnPinChanged;

    public CreditCard(string number, string owner, string expiry,
                      int pin, double limit, double balance)
    {
        CardNumber = number;
        OwnerName = owner;
        ExpiryDate = expiry;
        Pin = pin;
        CreditLimit = limit;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        OnDeposit?.Invoke($"Рахунок поповнено на {amount}. Баланс: {Balance}");
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        OnWithdraw?.Invoke($"Витрачено {amount}. Баланс: {Balance}");

        if (Balance < 0)
            OnCreditStart?.Invoke("Почалося використання кредитних коштів");

        if (Math.Abs(Balance) >= CreditLimit)
            OnLimitReached?.Invoke("Досягнуто кредитного ліміту!");
    }

    public void ChangePin(int newPin)
    {
        Pin = newPin;
        OnPinChanged?.Invoke("PIN успішно змінено");
    }
}
