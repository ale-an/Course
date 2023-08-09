namespace Module7.Homework;

public class Address
{
    public string City;
    public string Street;
    public string Building;

    public Address(string city, string street, string building)
    {
        City = city;
        Street = street;
        Building = building;
    }

    public string GetText()
    {
        return $"г. {City}, ул. {Street}, д. {Building}";
    }
}