namespace Module6;

public class Rectangle
{
    public int a;
    public int b;


    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int c)
    {
        a = c;
        b = c;
    }

    public Rectangle(int z, int x)
    {
        a = z;
        b = x;
    }

    public int Square()
    {
        return a * b;
    }
}