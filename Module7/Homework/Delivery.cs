namespace Module7.Homework;

public abstract class Delivery
{
    public Address Address;
}

public class HomeDelivery : Delivery
{
}

public class PickPointDelivery : Delivery
{
}

public class ShopDelivery : Delivery
{
}