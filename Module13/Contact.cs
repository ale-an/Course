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