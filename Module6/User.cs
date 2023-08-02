namespace Module6;

public class User
{
    private int age;

    public int Age
    {
        get { return age; }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }

    private string login;

    public string Login
    {
        get { return login; }

        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин должен быть не менее 3 символов");
            }
            else
            {
                login = value;
            }
        }
    }
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
