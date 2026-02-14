using System;

class Program
{
    static void Main()
    {
       
        Action showTime = () =>
        {
            Console.WriteLine("Поточний час: " + DateTime.Now.ToLongTimeString());
        };

        Action showDate = () =>
        {
            Console.WriteLine("Поточна дата: " + DateTime.Now.ToShortDateString());
        };

        Action showDay = () =>
        {
            Console.WriteLine("День тижня: " + DateTime.Now.DayOfWeek);
        };

      
        Func<double, double, double> triangleArea = (a, h) =>
        {
            return 0.5 * a * h;
        };

        Func<double, double, double> rectangleArea = (a, b) =>
        {
            return a * b;
        };

        Predicate<double> isPositive = x => x > 0;

        showTime();
        showDate();
        showDay();

        Console.WriteLine("Площа трикутника: " + triangleArea(10, 5));
        Console.WriteLine("Площа прямокутника: " + rectangleArea(4, 6));

        Console.WriteLine("Число додатне? " + isPositive(5));

        Console.WriteLine("\n--- Кредитна картка ---\n");

        CreditCard card = new CreditCard(
            "1234 5678 9012 3456",
            "Іваненко Іван",
            "12/26",
            1234,
            5000,
            1000
        );

     
        card.OnDeposit += msg => Console.WriteLine(msg);
        card.OnWithdraw += msg => Console.WriteLine(msg);
        card.OnCreditStart += msg => Console.WriteLine(msg);
        card.OnLimitReached += msg => Console.WriteLine(msg);
        card.OnPinChanged += msg => Console.WriteLine(msg);

        card.Deposit(500);
        card.Withdraw(2000);
        card.ChangePin(4321);
    }
}
