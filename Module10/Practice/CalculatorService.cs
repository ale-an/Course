namespace Module10.Practice;

public class CalculatorService
{
    private ILogger Logger { get; }

    public CalculatorService(ILogger logger)
    {
        Logger = logger;
    }

    public void Sum()
    {
        var a = EnterInt();
        Logger.Event("Пользователь ввел число!");
        var b = EnterInt();
        Logger.Event("Пользователь ввел число!");
        ICalculator calculator = new Calculator();
        int c = calculator.Sum(a, b);
        Console.WriteLine($"Сумма: {c}");
        Logger.Event("Сумма посчитана!");
    }

    private int EnterInt()
    {
        try
        {
            Console.WriteLine("Введите число");
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Logger.Error("Некорретный формат");
        }

        return EnterInt();
    }
}