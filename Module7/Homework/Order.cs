namespace Module7.Homework;

public abstract class Order<TDelivery> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public Product[] Products;
    public OrderStatus OrderStatus;

    public abstract void DisplayAddress();
}

public class OrderHome : Order<HomeDelivery>
{
    public override void DisplayAddress()
    {
        Console.WriteLine($"Доставка до дома: по адресу {Delivery.Address.GetText()}");
    }
}

public class OrderPickPoint : Order<PickPointDelivery>
{
    public override void DisplayAddress()
    {
        Console.WriteLine($"Доставка до пункта выдачи: по адресу {Delivery.Address.GetText()}");
    }
}

public class OrderShop : Order<ShopDelivery>
{
    public override void DisplayAddress()
    {
        Console.WriteLine($"Доставка до магазина: по адресу {Delivery.Address.GetText()}");
    }
}