namespace Module7.Homework;

public enum OrderStatus
{
    Created,
    Preparing,
    PrepareForShipping,
    Shipping,
    Ready,
    Finished
}

public static class OrderStatusExtensions
{
    public static string ToText(this OrderStatus status)
    {
        switch (status)
        {
            case OrderStatus.Created:
                return "Заказ создан";
            case OrderStatus.Preparing:
                return "Сборка заказа";
            case OrderStatus.PrepareForShipping:
                return "Подготовка к передаче в доставку";
            case OrderStatus.Shipping:
                return "Заказ передан в доставку";
            case OrderStatus.Ready:
                return "Заказ ожидает получения";
            case OrderStatus.Finished:
                return "Заказ получен";
            default:
                return "Неизвестно";
        }
    }
}