namespace Module7.Homework;

public class Product
{
    public double Price;
    public int Amount;
    public string Description;
    public Review[] Reviews;
}

public class Review
{
    protected User User;
    public string Text;

    public void Display()
    {
        Console.WriteLine($"Пользователь {User.Name} оставил отзыв о товаре: {Text}");
    }
}