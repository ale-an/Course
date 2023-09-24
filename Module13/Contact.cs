namespace Module13;

public class Contact
{
    public Contact(string name, long phoneNumber, String email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}

public class ContactDict
{
    public ContactDict(long phoneNumber, String email)
    {
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public long PhoneNumber { get; set; }
    public String Email { get; set; }
}