namespace Module7.Homework;

public abstract class User
{
    public string Name { get; set; }
    private string email;

    public string Email
    {
        get { return email; }

        set
        {
            if (value.Contains('@'))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("В электронной почте должен присутствовать символ @");
            }
        }
    }
}

public class Customer : User
{
    public string Age;
    public Address[] Addresses;

    public Customer(string age, Address[] addresses)
    {
        Age = age;
        Addresses = addresses;
    }
}

public class Seller : User
{
    public string CompanyName;
    public double Rating;
}

public class Courier : User
{
    public CourierType CourierType;
}

public enum CourierType : byte
{
    OnFoot = 1,
    ByCar = 2,
    ByBicycle = 3,
}