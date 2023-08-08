namespace Module7;

public class Helper
{
    static void Swap(ref int num1, ref int num2)
    {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
    }
}