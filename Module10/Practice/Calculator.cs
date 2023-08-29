namespace Module10.Practice;

public class Calculator : ICalculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}

public interface ICalculator
{
    int Sum(int a, int b);
}